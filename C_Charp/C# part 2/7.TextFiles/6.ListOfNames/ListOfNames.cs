using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ListOfNames
{
    class ListOfNames
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader(@"..\..\Names.txt");
            StreamWriter writer = new StreamWriter(@"..\..\Sorting.txt");
            using (reader)
            {
                List<string> Names = new List<string>();
                string row = reader.ReadLine();
                while (row != null)
                {
                    Names.Add(row);
                    row = reader.ReadLine();
              
                }
                Names.Sort();
                using (writer)
                {
                    foreach (string name in Names)
                        writer.WriteLine(name);
                }
                
            }

        }
    }
}
