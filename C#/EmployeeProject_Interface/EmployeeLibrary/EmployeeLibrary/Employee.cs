using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
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

    }
}
