using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Exceptions
{
    class TestExceptions
    {
        static void Main()
        {
            try
            {
                int number = ReadInteger(1, 100);
               
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message, ex.Start, ex.End);
            }

            try
            {
                DateTime someDate = ReadDateTime(new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));
                someDate.ToString();
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message, ex.Start, ex.End);
            }
           
        }

        static int ReadInteger(int start, int end)
        {
            int number;
            do
            {
                Console.WriteLine("Enter number between {0} and {1}", start, end);
            } while(!int.TryParse(Console.ReadLine(), out number));

            if (number < start || number > end)
            {
                throw new InvalidRangeException<int>("Number is not a range from 1 to 100", start, end);
            }
            else
            {
                return number;
            }
        }

        static DateTime ReadDateTime(DateTime start, DateTime end)
        {
            DateTime someDate;
            do
            {
                Console.WriteLine("Enter date between {0} and {1}", start, end);
            } while (DateTime.TryParseExact(Console.ReadLine(), new string[] { "d/M/yyyy", "dd/MM/yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.None, out someDate));

            if (someDate < start || someDate > end)
            {
                throw new InvalidRangeException<DateTime>("Date is not a range from 1.1.1980 to 31.12.2013", start, end);
            }
            else
            {
                return someDate;
            }

        }
    }
}
