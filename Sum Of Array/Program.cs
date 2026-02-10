using System;

class Program
{
    static void Sum()
    {
        int[] numbers = { 10, 20, 30, 40 };

        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum = sum + numbers[i];
        }

        Console.WriteLine("Sum = " + sum);
    }

    public static void Main(string[] args)
    {
        Sum();
    }
}
