using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.RandomNumber
{
    class RandomNumber
    {
        static void Main(string[] args)
        {
            Random RNumber = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", RNumber.Next(100, 201));
            }
        }
    }
}
