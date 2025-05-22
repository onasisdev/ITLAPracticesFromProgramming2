using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map_of_classes
{
    public abstract class CommunityMember : Rector
    {
        public int EmployeeId { get; set; }
        public int StudentId { get; set; }
        public int ExStudentId { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string SocialId { get; set; }
        public string Address { get; set; }

    }
}
