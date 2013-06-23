using System;

class SumNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number n:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Now enter {0} numbers:", n);
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            int a = int.Parse(Console.ReadLine());
              sum += a;
        }
        Console.WriteLine("Sum is: {0}", sum);
    }
}

