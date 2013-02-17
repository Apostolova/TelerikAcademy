using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tubes
{
    static void Main(string[] args)
    {
        ushort N = ushort.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int[] tubes = new int[N];
        for (int i = 0; i <= N - 1; i++)
        {
            tubes[i] = int.Parse(Console.ReadLine());
        }
        int left = 1;
        int right = 2000000000;
        int middle = (left + right) / 2;
        int bestSum;
        while (left <= right)
        {
            bestSum = 0;
            for (int i = 0; i <= N - 1; i++)
            {
                bestSum += tubes[i] / middle;
            }
            if (bestSum == M)
            {
                left = middle + 1;
            }
            else
            {
                if (bestSum < M)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            middle = (left + right) / 2;

        }
        Console.WriteLine(middle);
    }
}

