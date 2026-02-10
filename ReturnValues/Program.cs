using System;

public class Program
{
    public static void SayHello()
    {
        Console.WriteLine("Hello!");
    }

    public static int GetAge()
    {
        return 25;
    }

    public static int Double(int x)
    {
        return x * 2;
    }

    public static bool IsPositive(int number)
    {
        return number > 0; 
    }

    public static int Task_3(int number)
    {
        return number * number;
    }



    public static void Main(string[] args)
    {
        SayHello();

        int age = GetAge();
        Console.WriteLine("Age: " + age);

        int result = Double(5);
        Console.WriteLine("Double of 5 is: " + result);

        bool isPositive = IsPositive(3);
        Console.WriteLine("3 is positive: " + isPositive);

        int squared = Task_3(4);
        Console.WriteLine("Square of 4 is: " + squared);

    }
}