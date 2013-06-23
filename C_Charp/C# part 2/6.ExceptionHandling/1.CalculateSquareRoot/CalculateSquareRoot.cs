using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CalculateSquareRoot
{
    class CalculateSquareRoot
    {
        static void Main(string[] args)
        {

            try
            {
                int N = int.Parse(Console.ReadLine());
                if (N < 0)
                {
                    throw new ArgumentOutOfRangeException ();
                    return;
                }
                double Square = Math.Sqrt(N);
                Console.WriteLine("Square root of number N is : {0}", Square);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
