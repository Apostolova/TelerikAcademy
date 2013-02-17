using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that reverses the digits of given decimal number. Example: 256 -> 652


namespace _7.ReverseDigitOfNumbers
{
    class ReverseDigitOfNumbers
    {
        public static char [] ReverseDigit(char [] arr)
        {
            int length = arr.Length;
            char[] reverse = new char[length];
            if (arr[0] == '-')
            {
                reverse[0] = arr[0];
                for (int index = 1; index < length; index++)
                {
                    reverse[length - index ] = arr[index];
                }
                return reverse;
            }
            else
            {
                for (int index = 0; index < length; index++)
                {
                    reverse[length - index - 1] = arr[index];
                }
                return reverse;
            }
        }

        public static void PrintArray(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }

        static void Main()
        {
            decimal N = decimal.Parse(Console.ReadLine());
            string number =(Convert.ToString(N));
            char [] array = number.ToCharArray();
             ReverseDigit(array);
            PrintArray(ReverseDigit(array));
            Console.WriteLine();
           
        }
    }
}
