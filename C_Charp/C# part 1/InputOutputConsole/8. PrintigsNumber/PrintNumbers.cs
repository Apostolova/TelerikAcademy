using System;

class PrintNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("That the numbers from 1 to {0}", n );
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

