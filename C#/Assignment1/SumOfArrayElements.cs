using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class SumOfArrayElements
    {
        public double GetSum(double[] numbers)
        {
            double ans = 0;
            foreach(double num in numbers)
            {
                ans += num;
            }
            return ans;
        }
    }
}
