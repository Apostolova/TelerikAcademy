using System;

class Bit3
{
    static void Main()
    {
        Console.WriteLine("Enter the value for number:");
        int number = int.Parse(Console.ReadLine());
        int p = 4;
        int mask = 1 << p;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> p;
        if (bit == 0)
        Console.WriteLine(Convert.ToString(bit, 2).PadLeft(8, '0'));
        Console.WriteLine("The third bit from number {0} is: {1}", number, bit);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '0'));
    }
}

