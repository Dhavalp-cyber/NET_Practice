using System;
class VoidMethodPractice
{
    // Void method without parameters
    public static void sayHello()
    {
        Console.WriteLine("Hello");
    }

    // Void method with parameters
    public static void PrintNumber(int number)
    {
        Console.WriteLine(number);
    }   

    public static void main(string[] args)
    {
        sayHello(); // Output: Hello
        PrintNumber(42); // Output: 42
    }

}

class ACcessModifierExample
{
    // Private void method
    private static void SecretMethod()
    {
        Console.WriteLine("This is a private method.");
    }
    // Public void method
    public static void PublicMethod()
    {
        Console.WriteLine("This is a public method.");
    }

    public static void CallPrivateMethod()
    {
        SecretMethod(); 
    }
}

public class staicVSInstance
{
    
    public static void StaticMethod()
    {
        Console.WriteLine("This is a static method.");
    }
    
    public void InstanceMethod()
    {
        Console.WriteLine("This is an instance method.");
    }
}

class Task_1
{
    private static void PrintGreeting()
    {
        Console.WriteLine("Hello, World!");
    }

    public static void Greet()
    {
        PrintGreeting();
    }
}




class Program
{
    public static void Main(string[] args)
    {
        // For Outside class
        VoidMethodPractice.sayHello();
        VoidMethodPractice.PrintNumber(42);

        // For Access Modifier Example
        // ACcessModifierExample.SecretMethod(); ==> This will cause a compile-time error because SecretMethod is private and cannot be accessed from outside the class.
        ACcessModifierExample.PublicMethod();
        ACcessModifierExample.CallPrivateMethod();

        // For Static vs Instance Methods
        staicVSInstance.StaticMethod(); 
        staicVSInstance obj = new staicVSInstance(); 
        obj.InstanceMethod();

        // For Task 1
        Task_1.Greet();

    }
}
