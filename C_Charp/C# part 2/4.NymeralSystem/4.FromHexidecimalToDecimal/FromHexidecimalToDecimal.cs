using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert hexadecimal numbers to their decimal representation.


namespace _4.FromHexidecimalToDecimal
{
    class FromHexidecimalToDecimal
    {
        static void Main(string[] args)
        {
            int degree = 0;
            double Sum = 0;
            string N =  Console.ReadLine();
            Console.WriteLine(N);
            char[] arr = N.ToCharArray();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                switch (arr[i])
                {
                    case 'A': Sum += 10* Math.Pow(16, degree);
                        break;
                    case 'B': Sum += 11*Math.Pow(16, degree);
                        break;
                    case 'C': Sum += 12*Math.Pow(16, degree);
                        break;
                    case 'D': Sum += 13*Math.Pow(16, degree);
                        break;
                    case 'E': Sum += 14*Math.Pow(16, degree);
                        break;
                    case 'F': Sum += 15*Math.Pow(16, degree);
                        break;
                    default: int number = (int)Char.GetNumericValue(arr[i]);
                        Sum += number*Math.Pow(16, degree);
                        break;
                }
                degree++;
            }
            Console.WriteLine(Sum);
        }
    }
}
