using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinSearch
{
    static void Main()
    {
        Console.WriteLine("Enter size of array N =");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number K =");
        int K = int.Parse(Console.ReadLine());
        int [] arr = new int [N];
        for (int i = 0; i < N; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N; i++)
        {
           int min = i;
            for (int j = i + 1; j < N; j++)
            {
                if (arr[min] > arr[j])
                {
                    min = j;
                }
            }
            int m = arr[min];
            arr[min] = arr[i];
            arr[i] = m;
        }

        int index = Array.BinarySearch(arr, K);
        if (arr[0] > K)
        {
            Console.WriteLine("There isn't such a number in the array.");
        }
        else
        {
            if (index >= K)
            {
                Console.WriteLine("The largest number which is equal of K is {0} ", arr[index]);
            }
            else
            {
                Console.WriteLine("The largest number which is less to K is {0}", arr[-index - 2]);
            }
        }
    }
}

