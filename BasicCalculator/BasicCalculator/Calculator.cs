using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public double Add(double x, double y) 
        { 
            return x + y; 
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            if (y == 0)
            {
                // 2. Throw an exception to make the behavior consistent with the int version.
                throw new DivideByZeroException("Error: Cannot divide by zero.");
            }
            return x / y;
        }

        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                // 2. Throw an exception to make the behavior consistent with the int version.
                throw new DivideByZeroException("Error: Cannot divide by zero.");
            }
            return x / y;
        }
    }
}
