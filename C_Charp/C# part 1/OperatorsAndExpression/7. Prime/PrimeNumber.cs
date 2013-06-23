using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number for cheks is it prime i <=100");
        int i = int.Parse(Console.ReadLine());
        if (i > 100)
            Console.WriteLine("Please correct number");
        if ((i == 2) || (i == 3) || (i == 5))
            Console.WriteLine("The number {0} is prime", i, true);
        else
        {
            if ((i % 2 == 0) || (i % 3 == 0) || (i % 5 == 0))
                Console.WriteLine("the number isn't prime {0}", i, false);
            else
                Console.WriteLine("The number {0} is prime", i, true);
        }
    }
}

