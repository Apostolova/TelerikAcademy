using System;

class MaxNumber
{
    static void Main()
    {
        Console.WriteLine("Enter 2 numbres:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is {0}", Math.Max(a,b));
    }
}

