using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BiggerThanNext
{
    class BiggerThanNext
    {
        public static void Neighbours (int[] arr)
        {
            for (int i = 1; i <= arr.Length - 2; i++)
            {
                if ((arr[i] > arr[i + 1])&(arr[i]>arr[i-1]))
                {
                    Console.WriteLine("Index is {0}", i);
                    break;
                }
                else
                {
                    if (arr[i] == arr[arr.Length - 2])
                        Console.WriteLine("-1");
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 6, 7, 8, 9, 12, 13, 15 };
            Neighbours(array);


        }
    }
}
