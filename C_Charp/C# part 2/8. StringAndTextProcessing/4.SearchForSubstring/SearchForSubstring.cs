using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.SearchForSubstring
{
    class SearchForSubstring
    {
        static void Main(string[] args)
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string str = "we";
            int counter = Regex.Matches(text, str, RegexOptions.IgnoreCase).Count;
            Console.WriteLine(counter);
        }
    }
}
