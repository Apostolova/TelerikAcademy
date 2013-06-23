using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a number and prints it as a decimal number, 
//hexadecimal number, percentage and in scientific notation. 
//Format the output aligned right in 15 symbols.

namespace _11.NumberInAnyFormat
{
    class NumberInAnyFormat
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,15}", N);
            Console.WriteLine("{0,15:X}", N);
            Console.WriteLine("{0,15:P}", N);
            Console.WriteLine("{0,15:E}", N);
        }
    }
}
