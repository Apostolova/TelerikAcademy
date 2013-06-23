using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5.ChangeTextSurroundedByTag
{
    class ChangeTextSurroundedByTag
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            int startIndex = 0;
            int endIndex = 0;
            for (int i=0; i<text.Length-8; i++)
            { 
                if  (text.Substring(i, 8) == "<upcase>")
                {
                    startIndex = i+8;
                    i = startIndex;
                }
                if (text.Substring(i, 9) == "</upcase>")
                {
                    endIndex = i;

                    int lenght = endIndex - startIndex;
                    string Upper = text.Substring(startIndex, lenght).ToUpper();
                    text = text.Remove(startIndex, lenght);
                    text = text.Insert(startIndex, Upper);
                    text = text.Remove(startIndex - 8, 8);
                    text = text.Remove(endIndex - 8, 9);
                }
            }
            Console.WriteLine(text);
        }
    }
}
