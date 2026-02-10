using System;

class Program
{
    public static string Greet(string name, string Prename = "Hello")
    {
        return $"{Prename}, {name}!";
    }

    static void Main()
    {
        Console.WriteLine(Greet("Alice"));
        Console.WriteLine(Greet("Dhaval", "Hi"));
        Console.WriteLine(Greet("World", "Greetings"));
    }
}
