namespace ConsoleApp4;

public class ParameterDemo
{
    // Increasing using ref parameter
    public void Increase(ref int number)
    {
        number += 10;
    }

    // Assigning my full name using out parameter
    public void GetFullName(out string fullname)
    {
        fullname = "Usha Bajgain";   
    }

    // SumAll 
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        return sum;
    }
}

