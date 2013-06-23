using System;

class BitsPosition
{
    static void Main()
    {
        Console.WriteLine("Enter the value for number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value for position:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> p;
        if (bit == 1)
             Console.WriteLine("The {0} bit from number {1} -> true", p, number, true);
        else 
             Console.WriteLine("The {0} bit from number {1} -> false", p, number, false);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '0'));
    }
}

