using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Circle
    {
        public double[] AreaAndCircumference(double radius)
        {
            double[] ans = { 2 * Math.PI * radius, Math.PI * radius * radius };
            return ans;
        }
    }
}
