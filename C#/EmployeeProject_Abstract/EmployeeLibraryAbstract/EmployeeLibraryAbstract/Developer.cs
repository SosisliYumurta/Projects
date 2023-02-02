using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibraryAbstract
{
    public class Developer : Employee
    {
        public Developer(string name, string position, double salary, int age) : base(name, position, salary, age)
        {

        }
        public override void Fire(List<Employee> employees)
        {
            employees.Remove(this);
            Console.WriteLine("{0} has been fired",this.Name);
        }

        public override void IncreaseSalary(Employee employee, double rate)
        {
            throw new NotImplementedException();
        }
    }
}
