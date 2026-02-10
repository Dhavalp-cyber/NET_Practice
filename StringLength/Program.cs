using System;

class Program
{
    static void StringLength()
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();

        int count = 0;

        foreach (char c in text)
        {
            count++;
        }

        Console.WriteLine("Length = " + count);

        Console.WriteLine("First Character = " + text[0]);
    }

    public static void Main(string[] args)
    {
        StringLength();
    }
}
