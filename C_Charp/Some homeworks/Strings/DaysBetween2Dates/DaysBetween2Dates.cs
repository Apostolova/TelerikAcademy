using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
//Example:  Enter the first date: 27.02.2006
//			Enter the second date: 3.03.2004
//			Distance: 4 days



namespace _16.DaysBetween2Dates
{
    class DaysBetween2Dates
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first date:");
            string FirstDate = Console.ReadLine();
            Console.Write("Enter the second date:");
            string SecondDate = Console.ReadLine();
            int result;
            DateTime date1 = DateTime.ParseExact(FirstDate,"dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact(SecondDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            if (date1.Month == date2.Month)
            {
                result = date2.Day - date1.Day;
            }
            else
            {
                if (date1.Month % 2 != 0)
                {
                    result = (31 - date1.Day) + date2.Day;
                }
                else
                {
                    if (date1.Month == 2)
                    {
                        if (DateTime.IsLeapYear(date1.Year))
                        {
                            result = (29 - date1.Day) + date2.Day;
                        }
                        else
                        {
                            result = (28 - date1.Day) + date2.Day;
                        }
                    }
                    else
                    {
                        result = (30 - date1.Day) + date2.Day;
                    }
                }
            }
            Console.WriteLine("Distance {0} days ", result);


        }
    }
}
