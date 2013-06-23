using System;

class AreaTrapezoid
{
    static void Main()
    {
        Console.WriteLine("Parameters for trapezoid:");
        Console.WriteLine("Enter the value for a:");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value for number:");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value for number:");
        float h = float.Parse(Console.ReadLine());
        float area = ((a + b) * h) / 2;
        Console.WriteLine("Trapezoid's Area with sides a = {0}, b = {1} and height h = {2} is {3}", a, b, h, area);
    }
}

