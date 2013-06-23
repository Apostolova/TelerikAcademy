using System;

class GreatestOfFive
{
    static void Main()
    {
        int biggest=0;
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
                biggest = a;
            else
                biggest = b;
        }
        else
        {
            if (b > c)
                biggest = b;
            else
                biggest = c;
        }
        if (biggest > d)
        {
            if (biggest > e)
                biggest = biggest;
            else
                biggest = e;
        }
        else
        {
            if (d > e)
                biggest = d;
            else
                biggest = e;
        }
        Console.WriteLine("The biggest is {0}", biggest);
    }
}
