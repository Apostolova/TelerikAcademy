using System;

class Compares
{
    static void Main()
    {
        Console.WriteLine("First floating-point number");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.WriteLine("Second floating-point number");
        float secondNumber = float.Parse(Console.ReadLine());
        float precision = 0.000001f;
        float difference = Math.Abs(firstNumber - secondNumber);
        Console.WriteLine("The two numbers are equal with precision to 0.000001:");
        if (difference <= precision)
        {
            Console.WriteLine("true!");
        }
        else
        {
            Console.WriteLine("false!");
        }
    }
}

