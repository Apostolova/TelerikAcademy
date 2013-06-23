using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("Enter the value for x:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value for y:");
        int y = int.Parse(Console.ReadLine());
        if (((x * x ) + (y * y )) <= (25))  
            Console.WriteLine("The point ({0}, {1}) is inside a circle K(0, 5)", x, y, true);
        else
            Console.WriteLine("The point ({0}, {1}) is outside a circle K(0, 5)", x, y, false);
    }
}

