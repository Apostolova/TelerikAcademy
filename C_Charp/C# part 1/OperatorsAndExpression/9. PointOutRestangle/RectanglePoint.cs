using System;

class RectanglePoint
{
    static void Main()
    {
        Console.WriteLine("Insert value for x:");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert value for y:");
        int y = int.Parse(Console.ReadLine());
        if (((((x-1) * (x-1)) + ((y-1) * (y-1))) <= 9) && !((x > -1 && x < 1) && (y > 0 && y < 6)))
            Console.WriteLine("The point ({0}, {1}) is inside the circle K((1, 1), 3) and outdise the rectangle", x, y, true);
        else 
            Console.WriteLine("The point ({0}, {1}) is outside the circle K((1, 1), 3) or indise the rectangle", x, y, false);  
    }
}
