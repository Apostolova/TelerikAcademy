using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert decimal numbers to their binary representation.

namespace _1.FromDecimalToBinary
{
    class FromDecimalToBinary
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int digit;
            List<int> BinaryList = new List<int>();
            while (N > 0)
            {
                digit = N % 2;
                N /= 2;
                BinaryList.Add(digit);
            }
            BinaryList.Reverse();
            for (int i =0; i<BinaryList.Count; i++)
            {
                Console.Write( BinaryList[i]);
            }
            Console.WriteLine();

        }
    }
}
