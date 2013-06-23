using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ConcatenationOf3Files
{
    class ConcatenationOf3Files
    {
  
        static void Main(string[] args)
        {
            StreamReader readerFirst = new StreamReader(@"..\..\First.txt");
            StreamReader readerSecond = new StreamReader(@"..\..\Second.txt");
            StreamWriter Concatenation = new StreamWriter(@"..\..\Concatenation.txt");
            using (readerFirst)
            {
                string First = readerFirst.ReadToEnd();
                using (readerSecond)
                {
                    string Second = readerSecond.ReadToEnd();
                    string concat = First + Second;
                    using (Concatenation)
                    {
                        Concatenation.WriteLine(concat);
                    }
                   
                }
            }
        }
    }
}
