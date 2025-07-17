using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurePasswordGenerator.Domain.Entities;

namespace PasswordGenerator.Domain.Entities
{
    public class PasswordGeneration
    {
        public PasswordCriteria Criteria { get; set; }

        public PasswordGeneration(PasswordCriteria criteria)
        {
            this.Criteria = criteria;  
        }
    }
}
