using MyResume.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume.Application.Interfaces
{
    public interface IResumeAnalysisRepository
    {
        void SaveResumeAnalysis(ResumeAnalysis resumeAnalysis);
        Resume GetResumeAnalysisById(Guid resumeAnalysisId);
        void UpdateScore(Guid resumeAnalysisId, double newAnalysisScore);
        
    }
}
