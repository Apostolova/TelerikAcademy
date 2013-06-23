using System;

class SortingArray
{
    static void Main()
    {
        Console.WriteLine("Enter size of Array");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        int min;
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < N; i++)
        {
            min = i;
            for (int j = i+1; j < N; j++)
            {
                if (array[min] > array[j])
                {
                   min = j;
                }
            }
                    int k = array[min];
                    array[min] = array[i];
                    array[i] = k;
            }
        Console.WriteLine();
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

