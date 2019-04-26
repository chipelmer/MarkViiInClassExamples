using System;
using Xunit;
using MarkViiInClassExamples;

namespace TipCalc.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(100, .2, 20)]
        [InlineData(100, .15, 15)]
        [InlineData(50, .15, 7.5)]
        [InlineData(4, .20, 1)]
        [InlineData(1, .15, 1)]
        [InlineData(0, .15, 1)]
        [InlineData(-5, .15, 1)]
        public void ShouldCalculateTip(decimal checkAmount, decimal tipPercentage, decimal expected)
        {
            // Arrange
            TipCalculator tipCalculator = new TipCalculator();

            // Act
            decimal actual = tipCalculator.GetTipAmount(checkAmount, tipPercentage);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
