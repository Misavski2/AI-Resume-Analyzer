using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume.Domain.Interfaces
{
    public interface IAIService
    {
        public Task<string> GetAnonymizedJsonAsync(string rawText);
    }
}
