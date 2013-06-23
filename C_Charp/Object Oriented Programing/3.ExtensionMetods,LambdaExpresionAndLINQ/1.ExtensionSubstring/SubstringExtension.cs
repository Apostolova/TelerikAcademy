using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement an extension method Substring(int index, int length)
//for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.


namespace _1.ExtensionSubstring
{
    public static class SubstringExtension
    {
        public static StringBuilder Substring(this StringBuilder stringBuilder, int startIndex)
        {
            if (startIndex < 0 || startIndex > stringBuilder.Length)
            {
                throw new ArgumentOutOfRangeException("Incorrect start index");
            }

            string buildSubstring = stringBuilder.ToString().Substring(startIndex);
            stringBuilder.Clear();
            stringBuilder.Append(buildSubstring);
            return stringBuilder;
        }

        public static StringBuilder Substring(this StringBuilder stringBuilder, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex > stringBuilder.Length)
            {
                throw new ArgumentOutOfRangeException("Inccorect start index");
            }
            if (length < 0 || length > stringBuilder.Length)
            {
                throw new ArgumentOutOfRangeException("Inccorect length");
            }

            string buildSubstring = stringBuilder.ToString().Substring(startIndex, length);
            stringBuilder.Clear();
            stringBuilder.Append(buildSubstring);
            return stringBuilder;
        }


        static void Main(string[] args)
        {
            string str = "ala-bala-nica";
            StringBuilder subs = new StringBuilder();
            subs.Append(str);
    
            StringBuilder substring = subs.Substring(2, 5);
            Console.WriteLine(substring);
        }
    }
}
