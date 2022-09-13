using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Manager : Employee
    {
        private double PetrolAllowance;
        private double FoodAllowance;
        private double OtherAllowances;
        public Manager(int empNo, string empName, double salary) : base(empNo, empName, salary)
        {
            PetrolAllowance = 0.08 * salary;
            FoodAllowance = 0.13 * salary;
            OtherAllowances = 0.03 * salary;

        }
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            GrossSalary = GrossSalary + PetrolAllowance + FoodAllowance + OtherAllowances;
            NetSalary = NetSalary + PetrolAllowance + FoodAllowance + OtherAllowances;
        }
    }
}
