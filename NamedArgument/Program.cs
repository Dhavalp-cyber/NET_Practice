using System;

class Program
{
    public static string Profile(string name, int age, string city, bool isActive)
    {
        return $"{name}, {age}, {city}, {isActive}";
    }

    public static string CallWithNamedArguments(int scenario)
    {
        switch (scenario)
        {
            case 1:
                return Profile(isActive: true, city: "Paris", age: 25, name: "Alice");

            case 2:
                return Profile(city: "London", name: "Bob", age: 30, isActive: false);

            case 3:
                return Profile("Carol", 22, city: "Tokyo", isActive: true);

            case 4:
                return Profile("David", 40, "Berlin", false);

            default:
                return "Invalid scenario";
        }
    }

    static void Main()
    {
        Console.WriteLine(CallWithNamedArguments(1));
        Console.WriteLine(CallWithNamedArguments(2));
        Console.WriteLine(CallWithNamedArguments(3));
        Console.WriteLine(CallWithNamedArguments(4));
        Console.WriteLine(CallWithNamedArguments(21));
    }
}
