using System;

namespace CalculatorProject
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int Exponent(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

    }
}      