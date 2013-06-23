using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.AlphabeticalOrderList
{
    class AlphabeticalOrderList
    {
        static void Main(string[] args)
        {
            string names = "mouse house amber man woman one";
            string[] words = names.Split(' ');
            Array.Sort(words);
            foreach (string word in words)
                Console.WriteLine(word);
        }
    }
}
