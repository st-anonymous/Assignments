using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOPClassAssignment
{
    internal class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public double HRA { get; set; }
        public double TA { get; set; }
        public double DA { get; set; }
        public double PF { get; set; }
        public double TDS { get; set; }
        public double NetSalary { get; set; }
        public double GrossSalary { get; set; }

        public Employee(int empNo, string empName, double salary)
        {
            EmpNo = empNo;
            EmpName = empName;
            Salary = salary;
            SetSalaryComponents(salary);
        }
        private void SetSalaryComponents(double salary)
        {
            if(salary < 5000)
            {
                
                HRA = 0.1 * salary;
                TA = 0.05 * salary;
                DA = 0.15 * salary;
            }
            else if (salary < 10000)
            {

                HRA = 0.15 * salary;
                TA = 0.1 * salary;
                DA = 0.2 * salary;
            }
            else if (salary < 15000)
            {

                HRA = 0.2 * salary;
                TA = 0.15 * salary;
                DA = 0.25 * salary;
            }
            else if (salary < 20000)
            {

                HRA = 0.25 * salary;
                TA = 0.2 * salary;
                DA = 0.30 * salary;
            }
            else if (salary >= 20000)
            {

                HRA = 0.3 * salary;
                TA = 0.25 * salary;
                DA = 0.35 * salary;
            }

            GrossSalary = Salary + HRA + TA + DA;
            CalculateSalary(GrossSalary);
        }
        private void CalculateSalary(double grossSalary)
        {
            PF = 0.1 * grossSalary;
            TDS = 0.18 * grossSalary;
            NetSalary = grossSalary - (PF + TDS);
        }

        public string ShowGrossSalary()
        {
            return ($" Employee Number: {EmpNo}\n Employee Name: {EmpName}\n Gross Salary: {GrossSalary}");
        }

    }
}
