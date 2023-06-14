using System;

public class PrimeNumberChecker
{
    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        if (number <= 3)
            return true;

        if (number % 2 == 0 || number % 3 == 0)
            return false;

        int sqrt = (int)Math.Sqrt(number);

        for (int i = 5; i <= sqrt; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
                return false;
        }

        return true;
    }

    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(number))
            Console.WriteLine(number + " is a prime number.");
        else
            Console.WriteLine(number + " is not a prime number.");
    }
}
