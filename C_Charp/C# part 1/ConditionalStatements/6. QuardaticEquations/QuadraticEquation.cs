using System;

class QuadraticEquation
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("uravnenieto e {0}*x*x+{1}*x+{2}=0", a, b, c);
        float d = (b * b) - 4 * a * c;
        if (d == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("There is 1 real root: x={0}", x);
        }
        else
        {
            if (d > 0)
            {
                double x1 = (-b - (Math.Sqrt(d))) / 2 * a;
                double x2 = (-b + (Math.Sqrt(d))) / 2 * a;
                Console.WriteLine("The roots: x1={0} and x2={1}", x1, x2);
            }
            else
            {
                Console.WriteLine("There isn't real roots, D<0", true);
            }
        }
    }
}

    
