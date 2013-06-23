using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by
//first name and last name in descending order. Rewrite the same with LINQ.


namespace _05.LambdaExpresion
{
    class OrderByDescending
    {
        static void Main(string[] args)
        {
            Students [] arr =
            {
            new Students("Ivan", "Ivanov"),
            new Students("Petur", "Ivanov"),
            new Students("Stefan", "Dimitrov"),
            new Students("Ivan", "Staikov"),
            
            };
            Console.WriteLine("Lambda expresion");

            var SortedStudents = arr.OrderByDescending(Students => Students.FirstName).ThenByDescending(Students => Students.LastName);

            foreach (Students Students in SortedStudents)
            {
                Console.WriteLine("{0}, {1}", Students.FirstName, Students.LastName);
            }

            Console.WriteLine();
            Console.WriteLine("LINQ");

            var Sorted =
                from Students in arr
                orderby Students.FirstName descending, Students.LastName descending
                select Students;

            foreach (var Student in Sorted)
            {
                Console.WriteLine("{0}, {1}", Student.FirstName, Student.LastName);
            }
        }
    }
}
