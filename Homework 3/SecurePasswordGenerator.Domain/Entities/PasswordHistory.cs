using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurePasswordGenerator.Domain.Entities
{
    public class PasswordHistory
    {
        public int Id { get; set; }
        public string PasswordGenerated { get; set; }
        public DateTime CreatedIn { get; set; }
    }
}
