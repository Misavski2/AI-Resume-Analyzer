using MyResume.Domain.Entities;
using System;


namespace MyResume.Application.Interfaces
{
    public interface IResumeRepository
    {
        void SaveResume(Resume resume);
        Resume GetResumeById(Guid resumeId);
        Resume GetResumeByHash(string resumeHash);
        
    }
}
