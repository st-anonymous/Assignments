using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Calculator
    {
        public double Calculate(double num1, double num2, string op)
        {
            switch (op){
                case "+":
                    return Add(num1, num2);
                case "-":
                    return Subtract(num1, num2);
                case "*":
                    return Multiply(num1, num2);
                case "/":
                    return Divide(num1, num2);
                default:
                    throw new NotImplementedException();
            }
        }
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
