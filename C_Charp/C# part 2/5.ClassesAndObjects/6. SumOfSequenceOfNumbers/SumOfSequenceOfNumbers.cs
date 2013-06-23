using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.SumOfSequenceOfNumbers
{
    class SumOfSequenceOfNumbers
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            string sequence = "15 6 1 3 10 5";
            string [] numbers = sequence.Split(' ');
            foreach (string number in numbers)
            {
                Sum += int.Parse(number);
            }
            Console.WriteLine(Sum);
        }
    }
}
