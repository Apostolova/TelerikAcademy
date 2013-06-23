using System;

class MostFrequentNumber
{
    static void Main()
    {
        int[] arr = { 1, 5, 6, 1, 6, 6, 1, 1 };
        int number = 0;
        int bestNumber = 0;
        int times = 1;
        int bestTimes = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            number = arr[i];
            for (int j=1; j<arr.Length; j++)
            {
                if (i != j)
                {
                    if (arr[i] == arr[j])
                    {
                        times++;
                        if (times > bestTimes)
                        {
                            bestTimes = times;
                            bestNumber = number;
                        }
                    }
                }
            }
            times = 1;
        }
        Console.WriteLine("Most frequent number is {0} times {1}", bestNumber, bestTimes);
    }
}

