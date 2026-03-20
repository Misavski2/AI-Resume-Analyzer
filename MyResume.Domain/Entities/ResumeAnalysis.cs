using System;

namespace MyResume.Domain.Entities
{
    public class ResumeAnalysis
    {
        public Guid Id { get; private set; }
        public Guid ResumeId { get; private set; }
        public string JobDescription { get; private set; }
        public double Score { get; private set; }

        public ResumeAnalysis(Guid resumeId, string jobDescription, double score)
        {
            Id = Guid.NewGuid();
            ResumeId = resumeId;
            JobDescription = jobDescription;
            Score = score;

        }

    }
}
