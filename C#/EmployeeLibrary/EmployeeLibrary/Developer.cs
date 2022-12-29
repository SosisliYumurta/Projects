using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Developer : Employee
    {
        public Developer(string name, string position, double salary, int age) : base(name, position, salary, age)
        {

        }
    }
}
