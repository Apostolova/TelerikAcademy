using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that converts a string to a sequence of C# Unicode character literals.
// Use format strings. Sample input: Hi! -> \u0048\u0069\u0021

namespace _10.UnicodeWord
{
    class UnicodeWord
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
               string result = String.Format("{0}{1:X4}", @"\u", (int)word[i]);
                Console.Write(result);
            }
            Console.WriteLine();
        }
    }
}
