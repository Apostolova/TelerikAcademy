using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _9.ReplaceWord
{
    class ReplaceWord
    {
        static void Main(string[] args)
        {
            string str = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
           
            string[] words = "PHP, CLR, Microsoft".Split(',');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
                str = str.Replace(words[i], new string('*', words[i].Length));
            }
            Console.WriteLine(str);
        }
    }
}
