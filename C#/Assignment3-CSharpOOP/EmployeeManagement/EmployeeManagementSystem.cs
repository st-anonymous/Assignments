using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class EmployeeManagementSystem
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                Console.Write("\n 1. Add Employee\n 2. Show Salaries\n 3. No of Employees\n 4. Search Employee\n 0. Exit\n Enter Option: ");
                int opt = Convert.ToInt32(Console.ReadLine());
                if (opt == 0) break;
                if (opt == 1)
                {
                    int empNo;
                    string empName;
                    double salary;
                    int type;
                    Console.Write("\n 1. Manager\n 2. Marketing Executive\n 3. Normal Employee\n Enter Type of Employee: ");
                    type = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n Enter Employee Number: ");
                    empNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write(" Enter Employee Name: ");
                    empName = Convert.ToString(Console.ReadLine());
                    Console.Write(" Enter salary: ");
                    salary = Convert.ToDouble(Console.ReadLine());
                    switch (type)
                    {
                        case 1:
                            Manager mng = new Manager(empNo, empName, salary);
                            mng.CalculateSalary();
                            employees.Add(mng);
                            break;
                        case 2:
                            double kilometerTravel;
                            Console.Write(" Enter Kilometer Travelled: ");
                            kilometerTravel = Convert.ToDouble(Console.ReadLine());
                            MarketingExecutive mex = new MarketingExecutive(empNo, empName, salary, kilometerTravel);
                            mex.CalculateSalary();
                            employees.Add(mex);
                            break;
                        case 3:
                            Employee emp = new Employee(empNo, empName, salary);
                            emp.CalculateSalary();
                            employees.Add(emp);
                            break;
                    }
                }
                if (opt == 2)
                {
                    foreach (Employee emp in employees)
                    {
                        Console.WriteLine("\n" + emp.ShowDetails());
                    }
                }
                if (opt == 3)
                {
                    Console.WriteLine("\n Total Number of Employees is: " + employees.Count);
                }
                if (opt == 4)
                {
                    string name;
                    Console.Write("\n Enter Employee Name: ");
                    name = Console.ReadLine();
                    foreach (Employee emp in employees)
                    {
                        if(emp.EmpName == name ) Console.WriteLine("\n" + emp.ShowDetails());
                    }
                }
            }

        }
    }
}
