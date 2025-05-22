using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map_of_classes
{
    public class Administrator : Teacher
    {
        public Administrator(int EmployeeId, string FullName, 
            string socialId, string Position, 
            decimal Salary, string Address)
        {
            this.EmployeeId = EmployeeId;
            this.FullName = FullName;
            this.SocialId = socialId;
            this.Position = Position;
            this.Salary = Salary;
            this.Address = Address;
        }
    }
}
