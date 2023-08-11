using Calculator;
namespace CalculatorTests;

public class CalculatorTests
{
    [Theory]
    [InlineData(1,0,1)]
    [InlineData(5, 5, 10)]
    public void Add_ShouldAdd(int num1, int num2, int expected)
    {
        // Arrange
        var calculator = new Calc();

        // Act
        var result = calculator.Add(num1, num2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 0, 1)]
    [InlineData(5, 5, 0)]
    [InlineData(10, 5, 5)]
    public void Substract_ShouldSubtract(int num1, int num2, int expected)
    {
        // Arrange
        var calculator = new Calc();

        // Act
        var result = calculator.Subtract(num1, num2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(6, 3, 18)]
    public void Multiply_ShouldMultiply(int num1, int num2, int expected)
    {
        // Arrange
        var calculator = new Calc();

        // Act
        var result = calculator.Multiply(num1, num2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, 1, 1, 0)]
    [InlineData(20, 4, 5, 0)]
    [InlineData(9, 2, 4, 1)]
    public void Divide_ShouldDivide(int num1, int num2, int expected, int expectedRemainder)
    {
        // Arrange
        var calculator = new Calc();

        // Act
        var result = calculator.Divide(num1, num2);
        // Assert
        Assert.Equal(expected, result.result);
        Assert.Equal(expectedRemainder, result.remainder);
    }

    [Fact]
    public void Divide_ShowThrow_WhenDivideByZero()
    {
        var calculator = new Calc();

        Assert.Throws<DivideByZeroException>(() => calculator.Divide(1, 0));
    }
}