using System;

class ExtractBitFromNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the value for number:");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Your number like this:   ");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '0'));
        Console.WriteLine("Enter the value for position:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> p;
        Console.WriteLine("The {0} bit from number {1} is {2}", p, number, bit);
    }
}

