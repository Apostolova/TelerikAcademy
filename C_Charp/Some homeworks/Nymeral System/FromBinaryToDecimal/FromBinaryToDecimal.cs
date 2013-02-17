using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert binary numbers to their decimal representation.

namespace _2.FromBinaryToDecimal
{
    class FromBinaryToDecimal
    {
        static void Main(string[] args)
        {
            int digit = 0;
            string N = Console.ReadLine();
            double  Sum=0;
            char [] number = N.ToCharArray();
            for (int i=number.Length-1; i>=0; i--)
            {
                Sum += ((int)Char.GetNumericValue(number[i])) * Math.Pow(2, digit);
                digit++;
            }
            Console.WriteLine(Sum);
        }
    }
}
