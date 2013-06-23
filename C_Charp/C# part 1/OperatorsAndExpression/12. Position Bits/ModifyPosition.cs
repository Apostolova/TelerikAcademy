using System;

class ModifyPosition
{
    static void Main()
    {
        Console.WriteLine("Enter the value for number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value for position:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int numberAndMask = n & mask;
        int bit = numberAndMask >> p;
        if (bit == 1)
        {
            int maskInverse = ~(1 << p);
            int newNumber = maskInverse & n;
            Console.WriteLine("number={0} ({1}), p={2}, v=1, ->{3} ({4})", n, Convert.ToString(n, 2).PadLeft(8, '0'), p, newNumber, Convert.ToString(newNumber, 2).PadLeft(8, '0'));
            Console.WriteLine(newNumber);
        }
        else
        {
            int newNumber = n | mask;
            Console.WriteLine("number={0} ({1}), p={2}, v=0, ->{3} ({4})", n, Convert.ToString(n, 2).PadLeft(8, '0'), p, newNumber, Convert.ToString(newNumber, 2).PadLeft(8, '0'));
        }
    }
}
    