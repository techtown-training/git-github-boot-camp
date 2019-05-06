using Xunit;

namespace SimpleCalculatorLibrary.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnSum()
        {
            var calculator = new Calculator();

            var result = calculator.Add(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void Subtract_ShouldReturnDifference()
        {
            var calculator = new Calculator();

            var result = calculator.Subtract(1, 2);

            Assert.Equal(-1, result);
        }
    }
}
