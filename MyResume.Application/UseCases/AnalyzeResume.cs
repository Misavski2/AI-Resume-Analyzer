using System;
using MyResume.Application.Interfaces;
using MyResume.Domain.Entities;
using MyResume.Application.Common;

namespace MyResume.Application.UseCases
{
    public class AnalyzeResume
    {
        private readonly IPdfExtractor _pdfExtractor;
        private readonly IHashGenerator _hashGenerator;
        private readonly IAnalyzeResume _analyzeResume;
        private readonly IResumeRepository _resumeRepository;
        private readonly IResumeAnalysisRepository _resumeAnalysisRepository;


        public AnalyzeResume(IPdfExtractor pdfExtractor, IHashGenerator hashGenerator, IAnalyzeResume analyzeResume, 
            IResumeRepository resumeRepository, IResumeAnalysisRepository resumeAnalysisRepository)
        {
            _pdfExtractor = pdfExtractor;
            _hashGenerator = hashGenerator;
            _analyzeResume = analyzeResume;
            _resumeRepository = resumeRepository;
            _resumeAnalysisRepository = resumeAnalysisRepository;
        }

        public Result<ResumeAnalysis> Analyze(string pathFile, string jobDescription)
        {
            var rawText = _pdfExtractor.ExtractText(pathFile);

            var hash = _hashGenerator.GetHash(rawText);

            var duplicatedResume = _resumeRepository.GetResumeByHash(hash);

            

            if (duplicatedResume != null)
            {
                return Result<ResumeAnalysis>.Fail("Resume already analyzed");
            }

            Resume resume = new Resume(rawText, hash);

            _resumeRepository.SaveResume(resume);

            var score = _analyzeResume.CalculateScore(resume, jobDescription);


            ResumeAnalysis resumeAnalysis = new ResumeAnalysis(resume.Id, jobDescription, score);

            _resumeAnalysisRepository.SaveResumeAnalysis(resumeAnalysis);

            return Result<ResumeAnalysis>.Success(resumeAnalysis);


        }
    }
}
