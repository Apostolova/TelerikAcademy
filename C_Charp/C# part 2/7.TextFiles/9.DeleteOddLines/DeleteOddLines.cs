using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\Text.txt");
            StreamWriter writer = new StreamWriter(@"..\..\tempFile.txt");
            using (reader)
            {
                using (writer)
                {
                    string row = reader.ReadLine();
                    int lineNumber = 1;
                    while (row != null)
                    {
                        if ((lineNumber % 2) != 0)
                        {
                            writer.WriteLine(row);
                        }
                        lineNumber++;
                        row = reader.ReadLine();
                    }
                }
            }
            File.Replace(@"..\..\tempFile.txt", @"..\..\Text.txt", @"..\..\backup.txt");
        }
    }
}
