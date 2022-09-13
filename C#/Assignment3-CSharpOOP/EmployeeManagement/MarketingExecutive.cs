using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MarketingExecutive : Employee
    {
        private double KilometerTravel;
        private double TourAllowance;
        private double TelephoneAllowance = 1000;
        public MarketingExecutive(int empNo, string empName, double salary, double kilometerTravel) : base(empNo, empName, salary)
        {
            KilometerTravel = kilometerTravel;
            TourAllowance = 5 * KilometerTravel;
        }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
            GrossSalary = GrossSalary + TourAllowance + TelephoneAllowance;
            NetSalary = NetSalary + TourAllowance + TelephoneAllowance;
        }
    }
}
