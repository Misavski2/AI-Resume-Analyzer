using MyResume.Domain.Entities;
using System;


namespace MyResume.Application.Interfaces
{
    public interface IResumeAnalyze
    {
        double CalculateScore(Resume resume, string jobDescription);
 
    }
}
