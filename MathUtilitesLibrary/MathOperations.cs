using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilitiesLibrary
{
    public static class MathOperations
    {
        public static double Add(double x, double y)
        {
            double output = 0;
            output = x + y; 
            return output;
        }

        public static double Subtract(double x, double y)
        {

            double output = 0;
            output = x - y;
            return output;
        }

        public static double Multiply(double x, double y)
        {
            double output = 0;
            output = x * y;
            return output;

        }

        public static double Divide(double x, double y) 
        {

            double output = 0;
            output = x / y;
            return output;
        }
    }
}
