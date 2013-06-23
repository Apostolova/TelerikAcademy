using System;

class DivisionBy5
{
    static void Main()
    {
        Console.WriteLine("Enter 2 numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int br = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
                br++;
        }
        Console.WriteLine("There is {0} number which divided by 5 between {1} and {2}", br, a, b);
    }
}
