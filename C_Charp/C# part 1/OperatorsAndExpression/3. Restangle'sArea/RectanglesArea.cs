using System;

class RectanglesArea
{
    static void Main()
    {
        Console.WriteLine("Enter the value for width:");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value for height:");
        int height = int.Parse(Console.ReadLine());
        int area = (width * height);
        Console.WriteLine("If we have width: {0} and height: {1}, then rectangle's Area is: {2}", width, height, area);
    }
}

