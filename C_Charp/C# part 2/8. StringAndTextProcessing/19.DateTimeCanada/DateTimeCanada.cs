using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _19.DateTimeCanada
{
    class DateTimeCanada
    {
        static void Main(string[] args)
        {
            string str = "I was born at 14.06.1980. My sister was born at 03.07.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";
           // string str = "some text and some date line 10.01.2015 and some more. text and 05.03.2051 some more mails line 22.12.2012 kraq na sveta 2k.12.2012";
            string format = "dd.MM.yyyy";
            foreach (var date in Regex.Matches(str, @"\d{2}.\d{2}.\d{4}"))
            {

                string dateToString = Convert.ToString(date);

                DateTime correctdate = DateTime.ParseExact(dateToString, format, CultureInfo.InvariantCulture);

                Console.WriteLine(correctdate.ToString(CultureInfo.GetCultureInfo("en-CA")));
            }
        }
    }
}
