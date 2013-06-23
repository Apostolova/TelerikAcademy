using System;

class SortDescending
{
    static void Main()
    {
        Console.WriteLine("Enter 3 real numbers:");
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = decimal.Parse(Console.ReadLine());
        if (a > b)
        {
            {
                if (b > c)
                    Console.WriteLine("Sort in descending {0}, {1}, {2}", a, b, c);
                else
                    Console.WriteLine("Sort in descending {0}, {1}, {2}", a, c, b);
            }
            if (c > a)
            {
                if (b > a)
                    Console.WriteLine("Sort in descending {0}, {1}, {2}", c, b, a);
                else
                    Console.WriteLine("Sort in descending {0}, {1}, {2}", c, a, b);
            }
        }
        else
        {
            if (a > c)
                Console.WriteLine("Sort in descending {0}, {1}, {2}", b, a, c);
            else
                Console.WriteLine("Sort in descending {0}, {1}, {2}", b, c, a);
        }
    }
}
