using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Maximum
    {
        public double GetMaximum(double[] averages)
        {
            double ans = averages.Max(x => x);
            return ans;
        }
    }
}
