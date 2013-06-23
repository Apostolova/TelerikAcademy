using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8.CleanText
{
    class CleanText
    {
        static void Main(string[] args)
        {
            string str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string word = "in";

            foreach (Match sentence in Regex.Matches(str, @"\s*([^\.]*\b" + word + @"\b.*?\.)"))
                Console.WriteLine(sentence.Groups[1]);
        }
    }
}
