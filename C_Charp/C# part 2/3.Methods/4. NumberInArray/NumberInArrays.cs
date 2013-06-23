using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInArray
{
    public class NumberInArrays
    {
        public static int CountTimesNumberAppears(int a, int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == a)
                    count++;
            }
            return a;

        }
       public static void Main(string[] args)
        {
        }
    }
}
