using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ChecksBiggerThanNeighbours
{
    class ChecksBiggerThanNeighbours
    {
        public static bool Checks(int[] arr, int position)
        {
                if (position == 0)
                {
                    if (arr[1] > arr[position])
                        return true;
                    else
                        return false;
                }
                if (position == arr.Length - 1)
                {
                    if (arr[arr.Length-2] < arr[position])
                        return true;
                    else
                        return false;
                }
                else
                {
                    if ((arr[position-1] < arr[position])& (arr[position] < arr[position + 1]))
                        return true;
                    else
                        return false;
                }
        }
        static void Main(string[] args)
        {
            int[] arrays = new int[] { 2, 8, 10, 12, 15};
            int n = 4;
            Console.WriteLine(Checks(arrays, n));
            
        }
    }
}
