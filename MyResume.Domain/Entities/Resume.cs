using System;


namespace MyResume.Domain.Entities
{
    public class Resume
    {

        public Guid Id { get; private set; }
        public string Skills { get; private set; }
        public string Experience { get; private set; }
        public string RawText { get; private set; }


        public Resume( string skills, string experience, string rawText )
        {
         
            if (string.IsNullOrWhiteSpace(skills))
            {
                throw new ArgumentException("Não foi encontrado nenhuma habilidade em seu currículo.");
            }

            Skills = skills;

            if (string.IsNullOrWhiteSpace(experience))
            {
                throw new ArgumentException("Não foi encontrado nenhuma experiencia em seu currículo.");
            }

            Experience = experience;

            RawText = rawText;

            Id = Guid.NewGuid();
        }

    }
}
