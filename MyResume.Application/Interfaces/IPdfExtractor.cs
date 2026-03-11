using System;


namespace MyResume.Application.Interfaces
{
    public interface IPdfExtractor
    {
        string ExtractText(string pathFile);
    }
}
