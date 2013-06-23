using System;

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter 2 numbers:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("The greater number is {0}", a);
        }
        else
        {
            a = b;
            Console.WriteLine("The greater number is {0}", a);
        }
    }
}

