using System;
using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(2, 3, "+", 5)]
        [InlineData(5, 7, "-", -2)]
        [InlineData(4, 6, "*", 24)]
        [InlineData(10, 2, "/", 5)]
        public void ValidOperations_ReturnExpectedResult(double a, double b, string op, double expected)
        {
            double result = Calculator.Calculate(a, b, op);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DivideByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() =>
                Calculator.Calculate(5, 0, "/"));
        }

        [Fact]
        public void InvalidOperator_ThrowsInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() =>
                Calculator.Calculate(1, 2, "%"));
        }
    }
}
