using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOPClassAssignment
{
    internal class EmployeeManagementSystem
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                Console.Write("\n 1. Add Employee\n 2. Show Salary\n 0. Quit\n Choose Your Action: ");
                int opt = Convert.ToInt32(Console.ReadLine());
                if (opt == 0) break;
                if (opt == 1)
                {
                    int empNo;
                    string empName;
                    double salary;
                    Console.Write("Enter Employee Number: ");
                    empNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Employee Name: ");
                    empName = Convert.ToString(Console.ReadLine());
                    Console.Write("Enter salary: ");
                    salary = Convert.ToDouble(Console.ReadLine());
                    Employee emp = new Employee(empNo, empName, salary);
                    employees.Add(emp);
                }
                if (opt == 2)
                {
                    foreach (Employee emp in employees)
                    {
                        Console.WriteLine("\n" + emp.ShowGrossSalary());
                    }
                }
            }
            
        }
    }
}
