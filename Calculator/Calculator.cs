namespace Calculator;

public class Calc
{
    public int Add(int num1, int num2) => num1 + num2;

    public int Subtract(int num1, int num2) => num1 - num2;

    public int Multiply(int num1, int num2) => num1 * num2;

    public (int result, int remainder) Divide(int num1, int num2)
    {
        var result = num1 / num2;
        var remainder = num1 % num2;

        return (result, remainder);
    }
}
