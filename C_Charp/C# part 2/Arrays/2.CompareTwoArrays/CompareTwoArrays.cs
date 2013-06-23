using System;

class CompareTwoArrays
{
    static void Main()
    {
        Console.WriteLine("Enter size of array 1");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter size of array 2");
        int M = int.Parse(Console.ReadLine());
        int[] array1 = new int[N];
        int[] array2 = new int[M];
        Console.WriteLine("Enter elements of array 1");
        for (int i = 0; i < N; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }
       
        Console.WriteLine("Enter elements of array 2");
        for (int i = 0; i < M; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }
        if (M != N)
        {
            Console.WriteLine("Diferent size");
        }
        else
        {
            for (int i = 0; i < N; i++)
            {
                if (array1[i] != array2[i])
                {
                    Console.WriteLine("They are not the same");
                    break;
                }
                else
                    Console.WriteLine("They are the same");
            }
        }
    }
}
