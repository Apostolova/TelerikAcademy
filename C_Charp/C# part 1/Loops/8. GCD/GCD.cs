using System;

class GCD
{
    static void Main()
    {
        Console.WriteLine("Enter a=");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b=" );
        int b = int.Parse(Console.ReadLine());
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }
        if (a == 0)
           Console.WriteLine(b);
        else
            Console.WriteLine(a);
    }
}

