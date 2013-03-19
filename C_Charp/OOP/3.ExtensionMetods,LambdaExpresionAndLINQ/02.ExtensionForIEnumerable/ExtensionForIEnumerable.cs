using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement a set of extension methods for IEnumerable<T> 
//that implement the following group functions: sum, product, min, max, average.

namespace _02.ExtensionForIEnumerable
{
    public static class ExtensionForIEnumerable
    {
        public static T Sum<T>(this IEnumerable<T> enumeration) where T : IComparable
        {
            dynamic sum = enumeration.First();

            foreach(var item in enumeration.Skip(1))
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T Min<T>(this IEnumerable<T> enumeration) where T : IComparable
        {
            T min = enumeration.First();
            foreach (var item in enumeration.Skip(1))
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> enumeration) where T : IComparable
        {
            T max = enumeration.First();
            foreach (var item in enumeration.Skip(1))
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static T Product<T>(this IEnumerable<T> enumeration)
        {
            dynamic product = 1;
            foreach (var item in enumeration)
            {
                product *= item;
            }
            return product;
        }

        public static decimal Average<T>(this IEnumerable<T> enumeration)
        {
            dynamic sum = 0;
            decimal count = 0;
            
            foreach (var item in enumeration)
            {
                sum += item;
                count++;
            }
            
            return sum / count;
        }
        

        static void Main(string[] args)
        {
            int[] arr = new int[8];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            string[] str = new string[] { "I", "am", "ok", "think" };

            Console.WriteLine(arr.Sum());
            Console.WriteLine(str.Sum());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Product());
            Console.WriteLine(arr.Average());
        }
    }
}
