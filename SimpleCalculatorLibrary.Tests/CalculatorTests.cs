using Moq;
using Xunit;

namespace SimpleCalculatorLibrary.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Execute_ShouldReturnOperationResult()
        {
            var calculator = new Calculator();
            var operationMock = new Mock<IOperation>();
            operationMock.Setup(x => x.Execute(1, 2)).Returns(20);

            var result = calculator.Execute(operationMock.Object, 1, 2);

            Assert.Equal(20, result);
        }
    }
}
