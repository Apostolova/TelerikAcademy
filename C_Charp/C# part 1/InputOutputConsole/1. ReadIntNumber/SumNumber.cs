using System;

class SumNumber
{
    static void Main()
    {
        Console.WriteLine("Insert 3 integer number:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of number {0} + {1} + {2} = {3}", a, b, c, a+b+c);
    }
}

