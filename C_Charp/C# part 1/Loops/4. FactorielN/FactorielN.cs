using System;
using System.Numerics;

class FactorielN
{
    static void Main()
    {
        Console.WriteLine("Enter N > 1");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K > 1 ");
        int K = int.Parse(Console.ReadLine());
        if ((K < 1) | (K > N))
            Console.WriteLine("Incorrect numbers");
        BigInteger Factoriel = 1, FactorielN = 1, FactorielK = 1;
        do
        {
            FactorielN *= N;
            N--;
        }
        while(N > 0);
        do
        {
            FactorielK *= K;
            K--;
        }
        while (K > 0);
        Factoriel = FactorielN / FactorielK;
         Console.WriteLine( Factoriel);
    }
}

