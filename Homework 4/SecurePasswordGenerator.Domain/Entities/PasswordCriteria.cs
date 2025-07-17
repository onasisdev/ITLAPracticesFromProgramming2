using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurePasswordGenerator.Domain.Entities
{
    public class PasswordCriteria
    {
        public int PasswordLength { get; set; }
        public bool IncludeSpecialCharacters { get; set; }
        public bool IncludeNumbers { get; set; }
        public bool IncludeUppercaseLetters { get; set; }
        public bool IncludeLowerCaseLetters { get; set; }

        

    }
}
