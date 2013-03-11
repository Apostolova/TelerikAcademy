using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericListTest
    {
        static void Main()
        {
            GenericList<int> list = new GenericList<int>();
            list.Add (3);
            list.Add(8);
            list.Add(9);
            list.InsertElements(0, 1);
            list.InsertElements(3, 10);
            Console.WriteLine(list.ToString());
            Console.WriteLine();
            int min = list.Min();
            int max = list.Max();
            Console.WriteLine(min);
            Console.WriteLine(max);
            list.Clear();
            Console.WriteLine(list.ToString());
        }
    }
}
