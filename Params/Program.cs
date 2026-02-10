using System;

class Program
{
    public static int SumAll(params int[] numbers)
    {
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        return sum;
    }

    static void Main()
    {
        Console.WriteLine(SumAll(1, 2, 3));
        Console.WriteLine(SumAll(10));
        Console.WriteLine(SumAll());
        Console.WriteLine(SumAll(5, 5, 5, 5, 5));
    }
}
