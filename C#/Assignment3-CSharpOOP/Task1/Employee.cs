using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Employee : IPrintable
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        public double NetSalary { get; set; }
        public double GrossSalary { get; set; }

        public Employee(int empNo, string empName, double salary)
        {
            EmpNo = empNo;
            EmpName = empName;
            Salary = salary;
        }
        public virtual void CalculateSalary()
        {
            double salary = Salary;
            if (salary < 5000)
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
            PF = 0.1 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF + TDS);
        }
        public string ShowDetails() => ($"\t Employee Number: {EmpNo}\n\t Employee Name: {EmpName}\n\t Gross Salary: {GrossSalary}\n\t Net Salary: {NetSalary}");
    }
}
