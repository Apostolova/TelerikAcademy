using System;
using System.Collections.Generic;

class MaxSequanceOfEqualElements
{
    static void Main()
    {
        int len=1;
        int bestLen = 0;
        int bestElement = 0;
        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1,};
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                len++;
                if (len > bestLen)
                {
                    bestLen = len;
                    bestElement = array[i];
                }
            }
            else
            {
                len = 1;
            }
        }
        Console.WriteLine("The maximal sequence is {0} of equal elements {1}", bestLen, bestElement);
    }
}
