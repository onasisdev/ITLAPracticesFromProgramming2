using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map_of_classes
{
    public class Student : CommunityMember
    {
        public Student(int StudentId, string FullName,
            string SocialId, string Address)
        {
            this.StudentId = StudentId;
            this.FullName = FullName;
            this.SocialId = SocialId;
            this.Address = Address;
        }
    }
}

