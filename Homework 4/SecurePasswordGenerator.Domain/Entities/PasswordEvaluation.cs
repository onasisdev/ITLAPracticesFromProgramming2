using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator.Domain.Entities
{
    public class PasswordEvaluation
    {
        public string EvaluationStrengthMessage { get; set; }
        public List<string> Suggestions { get; set; }
        
        public PasswordEvaluation()
        {
            this.EvaluationStrengthMessage = string.Empty;
            this.Suggestions = [];
        }
    }
}
