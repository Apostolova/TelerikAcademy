using System;

class NotDivisibleBy3and7
{
    static void Main()
    {
        Console.Write("Enter N =");
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            if ((i % 3 != 0) | (i % 7 != 0))
                Console.WriteLine(i); 
        }
    }
}

