using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!" -> "Delphi not and PHP, not C++ not is C#!".


namespace _13.ReverseWord
{
    class ReverseWord
    {
        static void Main(string[] args)
        {
            string str = "C# is not C++, not PHP and not Delphi!";
            char [] symbol = new char [] {' ', '!', ','};
            List<string> str1 = str.Split(symbol ).ToList();
            StringBuilder reverse = new StringBuilder();
            for (int i =str1.Count- 1; i >= 0; i--)
            {
                reverse.Append(str1[i]);
                reverse.Append(" ");
            }
            reverse.Append("!");
            Console.WriteLine(reverse.ToString());
        }
    }
}
