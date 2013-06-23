using System;

class Divided5And7
{
    static void Main()
    {
        Console.WriteLine("Enter the value for number:");
        int num = int.Parse(Console.ReadLine());
        if ((num % 5 == 0) && (num % 7 == 0))
            Console.WriteLine("The Number {0} is divide 5 and 7 ", num, true);
        else
            Console.WriteLine("The number {0} isn't divide 5 and 7 in the same time", num, false);
    }
}

