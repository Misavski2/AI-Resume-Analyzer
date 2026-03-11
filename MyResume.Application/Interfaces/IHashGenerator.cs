using System;


namespace MyResume.Application.Interfaces
{
    public interface IHashGenerator
    {
        string GetHash(string rawText);
    }
}
