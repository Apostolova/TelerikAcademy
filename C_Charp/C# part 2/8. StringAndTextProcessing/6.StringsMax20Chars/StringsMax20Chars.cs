using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.StringsMax20Chars
{
    class StringsMax20Chars
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string with max 20 characters:");
            string str = Console.ReadLine();
            StringBuilder fullStr = new StringBuilder(str, 20);
            for (int i = str.Length; i < 20; i++)
            {
               fullStr.Append('*');
            }
            Console.WriteLine(fullStr);      
        }
    }
}
