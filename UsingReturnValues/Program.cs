using System;

class Program
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    static void Main()
    {
        int a = Add(5, 3);
        int b = Add(1, 2, 3);
        int c = Add(-5, 5);
        int d = Add(10, 20, 30);

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
    }
}

