using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AddNumbersLineToAnotherFile
{
    class AddNumbersLineToAnotherFile
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\Text.txt");
            StreamWriter writer = new StreamWriter(@"..\..\WithLines.txt");
            using (reader)
            {
                string row = reader.ReadLine();
                using (writer)
                {
                    int i = 1;
                    while (row != null)
                    {
                        writer.WriteLine("Line {0}, {1}", i, row);
                        i++;
                        row = reader.ReadLine();
                    }
                }
            }
        }
    }
}
