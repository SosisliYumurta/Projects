using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public interface IEmployeeService
    {
        void PrintEmployee(List<Employee> employees);
        void IncreaseSalary(Employee employee, double rate);
        void GetAvaregeAge(List<Employee> employees);
        double GetAvarageSalary(List<Employee> employees);
        void Fire(List<Employee> employees, Employee employee);
    }
}
