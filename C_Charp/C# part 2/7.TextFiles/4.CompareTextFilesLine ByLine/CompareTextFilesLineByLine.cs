using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CompareTextFilesLineByLine
{
    class CompareTextFilesLineByLine
    {
        static void Main(string[] args)
        {
            string same = null;
            string different = null;
            StreamReader First = new StreamReader(@"..\..\First.txt");
            StreamReader Second = new StreamReader(@"..\..\Second.txt");
            using (First)
            {
                using (Second)
                {
                    
                    int i = 1;
                    string rowFirst = First.ReadLine();
                    string rowSecond = Second.ReadLine();
                    while (rowFirst != null)
                    {

                        if (rowFirst.Equals(rowSecond))
                        {
                            same += i;
                            same += ", ";
                            i++;
                        }
                        else
                        {
                            different += i;
                            different += " ,";
                            i++;
                        }
                        rowFirst = First.ReadLine();
                        rowSecond = Second.ReadLine();
                    }
                }
            }
            Console.WriteLine("They are same lines {0}", same);
            Console.WriteLine("They are different lines {0}", different);
        }
    }
}
