using System;

class Matrix
{
    static void Main()
    {
        Console.WriteLine("Enter N=");
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine();
            for (int j = i; j < N+i ; j++)
            {
                Console.Write(j);
            }
        }
    }
}

