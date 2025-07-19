using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurePasswordGenerator.Application.Dtos
{
    public class PasswordEvaluationDto
    {
        public string EvaluationStrengthMessage { get; set; }
        public List<string> Suggestions { get; set; }

        public PasswordEvaluationDto()
        {
            this.EvaluationStrengthMessage = string.Empty;
            this.Suggestions = [];
        }
    }
}
