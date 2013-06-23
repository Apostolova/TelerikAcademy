using System;

class Fibonacii
{
    static void Main()
    {
        Console.Write("Enter N=");
        ulong N = ulong.Parse(Console.ReadLine());
        ulong[] fibonacci = new ulong[N];
        fibonacci[0] = 0;
        fibonacci[1] = 1;
        for (ulong i = 2; i <= N; i++)
        {
            fibonacci[i] = (fibonacci[i - 1] + fibonacci[i - 2]);
            Console.WriteLine(fibonacci[i]);
        }
    }
}

