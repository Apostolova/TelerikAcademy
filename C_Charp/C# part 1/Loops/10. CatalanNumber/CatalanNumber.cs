using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        Console.WriteLine("Enter N=");
        int N = int.Parse(Console.ReadLine());
        BigInteger factoriel = 1, factoriel2 = 1, factorielN = 1, catalanN = 1;
        for (int i = 1; i <= N; i++)
        {
            factoriel *= i;
        }
        for (int i = 1; i <= 2*N; i++)
        {
            factoriel2 *= i;
        }
        for (int i = 1; i <= N+1; i++)
        {
            factorielN *= i;
        }
        catalanN = factoriel2/(factorielN*factoriel);
        Console.WriteLine(catalanN);
    }
}

