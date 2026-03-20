using System;


namespace MyResume.Domain.Entities
{
    public class Resume
    {

        public Guid Id { get; private set; }
        public string RawText { get; private set; }
        public string Hash { get; private set; }


        public Resume(string rawText, string hash)
        {
            Id = Guid.NewGuid();
            RawText = rawText;
            Hash = hash;
        }

    }
}
