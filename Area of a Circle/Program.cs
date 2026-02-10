using System;

class Program
{
    static void AreaOfCircle()
    {
        Console.Write("Enter radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double pi = 3.14159;
        double area = pi * radius * radius;

        Console.WriteLine("Area = " + area);
    }

    public static void Main(string[] args)
    {
        AreaOfCircle();
    }
}
