using System;

class Program
{
    public static void TempratureCalculator()
    {
        Console.Write("Enter Celsius: ");
        double cel = Convert.ToDouble(Console.ReadLine());

        double fehrenheit = (cel * 9 / 5) + 32;

        Console.WriteLine("Fahrenheit = " + fehrenheit);
    }

    public static void Main(string[] args)
    {
        TempratureCalculator();
    }
}

