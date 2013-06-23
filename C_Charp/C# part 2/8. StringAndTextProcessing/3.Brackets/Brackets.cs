using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Brackets
{
    class Brackets
    {
        static void Main(string[] args)
        {
            int open = 0;
            int close = 0;
            string exprecesion = Console.ReadLine();
            for (int i = 0; i < exprecesion.Length; i++)
            {
                if (exprecesion[i].Equals('('))
                    open++;
                if (exprecesion[i].Equals(')'))
                    close++;
            }
            if (open == close)
                Console.WriteLine("The brackets is put correctly.");
            else
                Console.WriteLine("The bracket is put incorrectly.");
        }
    }
}
