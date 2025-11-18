namespace ConsoleApp4;

public class Calculator
{
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // Creating method Add
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Creating method Multiply
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}