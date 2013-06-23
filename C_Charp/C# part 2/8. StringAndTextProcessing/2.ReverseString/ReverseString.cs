using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
           string str = Console.ReadLine();
           char [] arr = str.ToCharArray();
           Array.Reverse(arr);
           Console.WriteLine(arr);
        }
    }
}
