using System;

class SequenceOfFibonacci
{
    static void Main()
    {
        ulong[] fibonacci = new ulong [100];
        fibonacci[0] = 0;
        fibonacci[1] = 1;
        for (ulong i = 2; i <= 98; i++)
        {
            fibonacci[i] = (fibonacci[i - 1] + fibonacci[i -2]);
            Console.WriteLine(fibonacci[i]);
        }
    }
}

