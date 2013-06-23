using System;
using System.Numerics;

class FactorielK
{
    static void Main()
    {
        Console.Write("Enter N=");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter K=");
        int K = int.Parse(Console.ReadLine());
        if ((N < 1) | (N > K))
            Console.WriteLine("Incorrect numbers");
        BigInteger Factoriel = 1, FactorielN = 1, FactorielK = 1, FactorielM = 1;
        int M = K - N;
        do
        {
            FactorielM *= M;
            M--;
        }
        while (M > 0);

        do
        {
            FactorielN *= N;
            N--;
        }
        while (N > 0);
        do
        {
            FactorielK *= K;
            K--;
        }
        while (K > 0);
        Factoriel = (FactorielN * FactorielK)/FactorielM;
        Console.WriteLine(Factoriel);
    }
}
