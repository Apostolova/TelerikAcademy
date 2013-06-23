using System;

class MaxSequenceOfElements
{
    static void Main()
    {
        int len = 1;
        int bestLen = 0;
        string Element = "";
        string bestElement = "";
        int[] array = { 6, 2, 3, 4, 5, 5, 2, 6, 7 };
        for (int i = 0; i < array.Length - 1; i++)
        {
                if (array[i] < array[i + 1])
                {
                    Element += array[i] + "";

                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestElement = Element + array[i+1];
                    }
                }
                else
                {
                    len = 1;
                }
            } 
        Console.WriteLine("Maximal sequence is from {0} elements from {1}", bestLen, bestElement);
    }
}

 
