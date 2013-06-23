using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReadTextFile
{
    class ReadTextFile
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\someText.txt");
            using (reader)
            {
                string row = reader.ReadLine();
                int lineNumber =1;
                while (row != null)
                {
                    if ((lineNumber % 2) != 0)
                    {
                        Console.WriteLine(row);
                    }
                    lineNumber++;
                    row = reader.ReadLine();
                }
            }
        }
    }
}
