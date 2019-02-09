using System;
using Xunit;

namespace CalculatorProject.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(-2, -4, -6)]
        public void AddTest(int a, int b, int expected)
        {

            //
            Calculator calculator = new Calculator();
            //
            int actual = calculator.Add(a, b);
            //
            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(2, 2, 0)]
        [InlineData(3, 3, 0)]
        public void SubtractTest(int a, int b, int expected)
        {

            //
            Calculator calculator = new Calculator();
            //
            int actual = calculator.Subtract(a, b);
            //
            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(-2, -4, 8)]
        public void MultiplyTest(int a, int b, int expected)
        {

            //
            Calculator calculator = new Calculator();
            //
            int actual = calculator.Multiply(a, b);
            //
            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 1)]
        [InlineData(6, 3, 2)]
        public void DivideTest(int a, int b, int expected)
        {

            //
            Calculator calculator = new Calculator();
            //
            int actual = calculator.Divide(a, b);
            //
            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(4, 4, 256)]
        [InlineData(3, 3, 27)]
        [InlineData(2, 2, 4)]
        public void ExponentTest(int a, int b, int expected)
        {

            //
            Calculator calculator = new Calculator();
            //
            int actual = calculator.Exponent(a, b);
            //
            Assert.Equal(expected, actual);
        }

    }
}



