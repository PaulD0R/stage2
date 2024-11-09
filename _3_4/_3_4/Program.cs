using System;

public class Program
{
    public static void Main()
    {
        int a = 5, b = 10;
        Console.WriteLine($"До: {a}, {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"После: {a}, {b}");
    }

    private static void Swap<T>(ref T first, ref T second)
    {
        (first, second) = (second, first);
    }
}