using System;

class ShowSing
{
    static void Main()
    {
        float a;
        float b;
        float c;
        if (a > 0) 
        {
            if (b > 0)
            {
                if (c > 0)
                    Console.WriteLine("The sing is +");
                else
                    Console.WriteLine("The sing is -");
            }
            else
            {
                if (c > 0)
                    Console.WriteLine("The sing is -");
                else
                    Console.WriteLine("The sing is +");
            }
            else
            { 
                if (c > 0) ^ (b > 0)
                {
                    Console.WriteLine("The sing is -");
                }
                else
                {
                    Console.WriteLine("The sing is +");

            }
        }
    }
}

