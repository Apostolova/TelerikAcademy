using System;

class Exchange
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Numbers are: a={0} and b={1}", a, b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("After exchange numbers are: a={0} and b={1}", a, b);
    }
}

