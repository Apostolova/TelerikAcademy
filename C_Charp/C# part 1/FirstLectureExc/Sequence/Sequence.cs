using System;

class Sequence
{
    static void Main()
    {
        for (int num = 2; num < 12; num++)
        {
            if (num % 2 == 0)
                Console.WriteLine(num);
            else
                Console.WriteLine(-num);

        }
    }
}

