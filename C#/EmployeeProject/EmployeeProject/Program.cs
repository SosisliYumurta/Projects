using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;
namespace EmployeeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee
                ("oguz", "student", 1500, 21);
            Employee employee2 = new Employee
                ("berk", "junier developer", 2000, 25);
            Employee employee3 = new Employee
                ("aydin", "senior developer", 2500, 31);

            Developer developer1 = new Developer("gusi", "developer", 4500, 10);

            EmployeeManager employeeManager
                = new EmployeeManager();

            List<Employee> employees
                = new List<Employee>();

            employeeManager.PrintEmployee(employees);

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(developer1);
            employeeManager.GetAvarageSalary(employees);
            Console.WriteLine(Employee.NumberOfEmployee());


            Console.WriteLine(Employee.NumberOfEmployee());

            employeeManager.PrintEmployee(employees);
            Console.WriteLine("---------------------------");

            employeeManager.IncreaseSalary(employee1, 10);

            employeeManager.PrintEmployee(employees);
            Console.WriteLine("---------------------------");


            employeeManager.GetAvaregeAge(employees);

            employeeManager.GetAvarageSalary(employees);

            employeeManager.PrintEmployee(employees);
            Console.WriteLine("---------------------------");

            //CalculateSalary(400, 13, employee1);
            employeeManager.PrintEmployee(employees);
            Console.WriteLine("---------------------------");


            employeeManager.Fire(employees, employee2);
            employeeManager.PrintEmployee(employees);

            employeeManager.GetAvarageSalary(employees);
            Console.WriteLine("---------------------------");
            Console.WriteLine(Employee.NumberOfEmployee());
            Console.WriteLine(employees.Count);
            employeeManager.GetAvaregeAge(employees);

            //double avgSalary = employees.Average(s => s.Salary);
            //var salary = employees.Where(s => s.Salary > avgSalary);
            //Console.WriteLine(salary);
            //----------------------------------

            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\Casper\\Desktop\\avarage_salary.txt");

                double avgSalary = employees.Average(s => s.Salary);
                Console.WriteLine(avgSalary);
                var salary = employees.Where(s => s.Salary > avgSalary);
                foreach (var item in salary)
                {
                    sw.WriteLine(item.Name + " "+ item.Salary);
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }








            Console.ReadLine();
        }

        public static double CalculateSalary(double hour, double rateOfHour, Employee employee)
        {

            return employee.Salary = hour * rateOfHour;

        }

    }

}
