using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSubstrings
{
    class ReplaceSubstrings
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\Text.txt");
            StreamWriter newReader = new StreamWriter(@"..\..\Text1.txt");
            using (reader)
            {
                string content = reader.ReadLine().ToLower();
                using (newReader)
                {
                    while (content != null)
                    {
                        string replaced = content.Replace("start", "finish");
                        newReader.WriteLine(replaced);
                        content = reader.ReadLine();
                    }
                }
            }
            File.Replace(@"..\..\Text1.txt", @"..\..\Text.txt", @"..\..\backup.txt");   
        }
    }
}
