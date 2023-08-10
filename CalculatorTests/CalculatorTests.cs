using Calculator;
namespace CalculatorTests;

public class CalculatorTests
{
    [Theory]
    [InlineData(1, 0, 1)]
    //[InlineData(1, 1, 2)]
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
    //[InlineData(1, 1, 0)]
    [InlineData(1, 0, 1)]
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
    [InlineData(1, 1, 1)]
    public void Divide_ShouldDivide(int num1, int num2, int expected)
    {
        // Arrange
        var calculator = new Calc();

        // Act
        var result = calculator.Divide(num1, num2);

        // Assert
        Assert.Equal(expected, result);
    }
}