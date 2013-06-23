using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter the value for number:");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
            Console.WriteLine("The Number {0} is even", num, true);
        else
            Console.WriteLine("The number {0} is odd", num, false);
    }
}

