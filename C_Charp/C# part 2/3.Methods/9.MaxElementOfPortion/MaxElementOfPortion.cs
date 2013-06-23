using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that return the maximal element in a portion of array of integers starting at given index.
// Using it write another method that sorts an array in ascending / descending order.


namespace _9.MaxElementOfPortion
{
    class MaxElementOfPortion
    {
        public static int MaximalInPortion(int[] arr, int index)
        {
            int max = index;
            for (int i = index + 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[max])
                {
                    arr[max] = arr[i];
                }
            }
                return arr[max];
        }

        public static int [] SortingArray(int[] arr)
        {
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        int k = arr[min];
                        arr[min] = arr[j];
                        arr[j] = k;
                    }
                }
            }
            return arr;
        }
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 1, 12, 8, 0, 3, 5};
            int YourIndex = 1;
            Console.WriteLine( MaximalInPortion(array, YourIndex));
            int[] array1 = new int[] { 10, 1, 12, 8, 0, 3, 5 };
            SortingArray(array1);
            Console.WriteLine();
            PrintArray(array1);
        }
    }
}
