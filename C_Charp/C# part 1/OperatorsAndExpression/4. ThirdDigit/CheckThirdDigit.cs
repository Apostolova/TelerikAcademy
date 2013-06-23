using System;

class CheckThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter the value for number:");
        int number = int.Parse(Console.ReadLine());
        int a = number / 100;
        int divide = a % 10;
        if (divide == 7)
            Console.WriteLine("The third divide of number {0} is 7: {1}", number, true);
        else
            Console.WriteLine("The third divide of number {0} is different from 7: {1}", number, false);
    }
}
