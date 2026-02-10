using System;

public class Program
{
    public static void Greet(string firstName, string lastName)
    {
        Console.WriteLine("Hello, " + firstName + " " + lastName);
    }

    public static void PrintRectangleArea(int width, int height, string unit)
    {
        Console.WriteLine(width * height + " " + unit);
    }

    public static void Task_2(int A , int B)
    {
        Console.WriteLine("Sum Of " + A + " and " + B + " is = " + (A + B));
    }


    public static void Main(string[] args)
    {
        Greet("Dhaval", "Patel");
        PrintRectangleArea(5, 10, "KM");

        Task_2(12, 3);
    }
}
