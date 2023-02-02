using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibraryAbstract
{
    public class Boss : Employee
    {
        public Boss(string name, string position, double salary, int age) : base(name, position, salary, age)
        {

        }

        public override void Fire(List<Employee> employees)
        {
            Console.WriteLine("The boss cannot be fired");
        }

        public override void IncreaseSalary(Employee employee, double rate)
        {
            throw new NotImplementedException();
        }
    }
}
