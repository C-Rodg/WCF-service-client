using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{

    public class Calculator : ICalculator
    {
        public double AddNumbers(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        public double SubtractNumbers(double num1, double num2)
        {
            Console.WriteLine("Hit it!");
            double result = num1 - num2;
            return result;
        }

        public double MultiplyNumbers(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        public double DivideNumbers(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
    }
}
