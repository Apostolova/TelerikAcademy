using System;

class NullValue
{
    static void Main()
    {
        int? number = 0;
        double? number1 = 0;
        Console.WriteLine(number);
        Console.WriteLine(number1);
        number = 5;
        number1 = 6d;
        Console.WriteLine(number);
        Console.WriteLine(number1);
        number = null;
        number1 = null;
        Console.WriteLine(number);
        Console.WriteLine(number1);
    }
}

