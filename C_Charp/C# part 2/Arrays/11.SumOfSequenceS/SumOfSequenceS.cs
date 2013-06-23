using System;

class SumOfSequenceS
{
    static void Main()
    {
        int[] arr = {4, 3, 1, 4, 2, 5, 8 };
        Console.WriteLine("Enter the Sum S = ");
        int S = int.Parse(Console.ReadLine());
        int sum = 0;
        string sequence = "";
        for (int i = 0; i < arr.Length - 1; i++)
        {
            sequence = Convert.ToString(arr[i]);
            sum = arr[i];
            for (int j = i+1; j < arr.Length; j++)
            {
                if (i != j)
                {
                    sum += arr[j];
                    sequence += "," + arr[j];
                    if (S == sum)
                    {
                        Console.WriteLine("The Sequence of Sum {0} is : {1}", S, sequence);
                    }
                }
            }
            sequence = "";
            sum = 0;
        }
    }
}
