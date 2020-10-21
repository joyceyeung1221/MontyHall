using System;
using Xunit;
namespace MontyHall.Test
{
    public class CalculatorTest
    {
        public CalculatorTest()
        {
        }

        [Fact]
        public void ShouldReturnAResult()
        {
            var calculator = new Calculator();
            var result = calculator.CalculateResult(PlayerStrategy.Switching, 66, 100);

            Assert.IsType<Result>(result);
        }
    }
}
