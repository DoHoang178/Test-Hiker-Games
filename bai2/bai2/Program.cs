using System;

public class Fibonacci
{
    public static void Main()
    {
        Console.WriteLine("100 number of Fibonacci are: ");
        PrintFibonacci();
    }

    public static void PrintFibonacci()
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(a);
            int temp = a;
            a = b;
            b = temp + b;
        }
    }
}
