using System;

class CircleAreaPerimeter
{
    static void Main()
    {
        Console.WriteLine("Enter radius 'r' of circle:");
        float r = float.Parse(Console.ReadLine());
        double C = 2 * Math.PI * r;
        double A = Math.PI * r * r;
        Console.WriteLine("The perimeter with this r={0} is C={1}", r, C );
        Console.WriteLine("The area is A={0}", A);

    }
}

