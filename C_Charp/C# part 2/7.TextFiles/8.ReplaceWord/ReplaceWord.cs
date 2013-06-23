using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8.ReplaceWord
{
    class ReplaceWord
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
                        string replaced = Regex.Replace(content,"\\bfinish\\b", "aaaaaa").ToLower();
                        newReader.WriteLine(replaced);
                        content = reader.ReadLine();
                    }
                }
            }
            File.Replace(@"..\..\Text1.txt", @"..\..\Text.txt", @"..\..\backup.txt"); 
        }
    }
}
