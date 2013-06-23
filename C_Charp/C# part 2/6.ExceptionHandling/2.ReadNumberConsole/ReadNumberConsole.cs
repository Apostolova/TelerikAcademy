using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ReadNumberConsole
{
    class ReadNumberConsole
    {
        static int ReadNumber(int start, int end, int a)
        {
            int N = int.Parse(Console.ReadLine());
            if ((N < start) | (N > end))
            {
                throw new ArgumentOutOfRangeException();
            }
            return N;
        }
        static void Main(string[] args)
        {
            int a = 1;
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                   a = ReadNumber(a, 100, i);
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number is not of range [1,100] or is smaller from before number");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("This is not correct number");
            }
        }
    }
}
