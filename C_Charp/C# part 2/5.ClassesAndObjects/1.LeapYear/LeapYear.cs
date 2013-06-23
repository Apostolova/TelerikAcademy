using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            ushort YourYear = ushort.Parse(Console.ReadLine());
            bool Leap = System.DateTime.IsLeapYear(YourYear);
            if (Leap)
            Console.WriteLine("Year is a leap.");
            else
                Console.WriteLine("Year is not a leap.");
        }
    }
}
