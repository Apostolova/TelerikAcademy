using System;

class SumS
{
    static void Main()
    {
        Console.WriteLine("Enter N=");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter X=");
        int X = int.Parse(Console.ReadLine());
        double Sum = 1;
        int factoriel = 1;
        for (int i = 1; i <= N; i++)
        {
            factoriel *= i;
            Sum += factoriel / Math.Pow(X, i);
        }
        Console.WriteLine(Sum);
    }
}

