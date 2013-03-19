using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

namespace _04.AgeBetweenLINQ
{
    class AgeBetween
    {
        static void Main(string[] args)
        {
            Students[] arr = 
            {
                new Students("Ivan", "Ivanov", 20),
                new Students("Ivan", "Petrov", 25),
                new Students("Petur", "Ivanov", 19),
            };

            var averageAge = 
                from students in arr
            
                where students.Age >= 18 && students.Age <=  24
                select students;

            foreach (var students in averageAge)
            {
                Console.WriteLine("{0}, {1}", students.FirstName, students.LastName);
            }
        }
    }
}
