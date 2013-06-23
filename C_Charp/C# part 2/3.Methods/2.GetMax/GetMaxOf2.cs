using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GetMaxOf2
{
    public static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static void Main()
    {
        int Number1 = int.Parse(Console.ReadLine());
        int Number2 = int.Parse(Console.ReadLine()); 
        int Number3 = int.Parse(Console.ReadLine());
        Console.WriteLine("The biggest number of 3 is {0}",(GetMax(GetMax(Number1, Number2),Number3)));
    }
}
