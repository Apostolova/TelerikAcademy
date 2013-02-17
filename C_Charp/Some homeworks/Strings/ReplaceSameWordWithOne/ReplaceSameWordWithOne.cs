using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and replaces 
//all series of consecutive identical letters with a single one. 
//Example: "aaaaabbbbbcdddeeeedssaa" -> "abcdedsa".

namespace _23.ReplaceSameWordWithOne
{
    class ReplaceSameWordWithOne
    {
        static void Main(string[] args)
        {
            string str = "aaaaannnnasddddddffdda";
            StringBuilder letter = new StringBuilder(str);
            for (int i = 0; i < letter.Length - 1; i++)
            {
                if (letter[i] == letter[i + 1])
                {
                    letter.Remove(i, 1);
                    i--;
                }
            }
            Console.WriteLine(letter);

        }
    }
}
