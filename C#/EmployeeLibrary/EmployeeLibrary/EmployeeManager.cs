using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class EmployeeManager : IEmployeeService
    {
        public void Fire(List<Employee> employees, Employee employee)
        {
            Employee.Counter--; 
            employees.Remove(employee);
            
            
        }

        public double GetAvarageSalary(List<Employee> employees)
        {
            double maxSalary = 0, minSalary = 0;
            double averageSalary = 0;

            foreach (var e in employees)
            {

                averageSalary += e.Salary;
            }
            maxSalary = employees[0].Salary;
            minSalary = employees[0].Salary;
            for (int i = 1; i < employees.Count; i++)
            {
                
                if (minSalary > employees[i].Salary)
                    minSalary = employees[i].Salary;
                else
                    maxSalary = employees[i].Salary;
            }

            Console.WriteLine("Avarage Salary= {0}, Maximum salary= {1}, Minimum salary= {2} ",Math.Round(averageSalary / Employee.NumberOfEmployee(), 1),maxSalary,minSalary);
            return averageSalary;

        }

        public void GetAvaregeAge(List<Employee> employees)
        {
            double averageAge = 0;
            foreach (var e in employees)
            {
                averageAge += e.Age;
            }
            Console.WriteLine("Avarage Age= " + Math.Round(averageAge / Employee.NumberOfEmployee(), 1));
        }

        public void IncreaseSalary(Employee employee, double rate)
        {
            employee.Salary += employee.Salary * rate / 100;

        }

        public void PrintEmployee(List<Employee> employees)
        {
            foreach (var e in employees)
            {
                Console.WriteLine("Name= {0}, Position= {1}, Salary= {2}, Age= {3}", e.Name, e.Position, e.Salary, e.Age);
            }
        }
    }
}
