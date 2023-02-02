using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibraryAbstract
{
    public abstract class Employee 
    {

        private string name;
        private string position;
        private double salary;
        private int age;
        private static int counter = 0;

        public Employee(string name, string position, double salary, int age)
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
            this.age = age;
            counter++;
        }
        public static int NumberOfEmployee()
        {
            // this method should be return int, so we can calculate income or expenses
            return Counter;
        }
        public static int Counter
        {
            get { return counter; }
            set { counter = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public static void PrintEmployee(List<Employee> employees)
        {
            foreach (var e in employees)
            {
                Console.WriteLine("Name= {0}, Position= {1}, Salary= {2}, Age= {3}", e.Name, e.Position, e.Salary, e.Age);
            }
        }
        public abstract void IncreaseSalary(Employee employee, double rate);
        public static void GetAvaregeAge(List<Employee> employees)
        {
            double averageAge = 0;
            foreach (var e in employees)
            {
                averageAge += e.Age;
            }
            Console.WriteLine("Avarage Age= " + Math.Round(averageAge / Employee.NumberOfEmployee(), 1));
        }
        public static double GetAvarageSalary(List<Employee> employees)
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

            Console.WriteLine("Avarage Salary= {0}, Maximum salary= {1}, Minimum salary= {2} ", Math.Round(averageSalary / Employee.NumberOfEmployee(), 1), maxSalary, minSalary);
            return averageSalary;
        }
        public abstract void Fire(List<Employee> employees);
       

    }
}

