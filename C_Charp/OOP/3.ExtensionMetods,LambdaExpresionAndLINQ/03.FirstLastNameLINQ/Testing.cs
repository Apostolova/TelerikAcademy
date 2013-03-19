using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that from a given array of students finds all students
//whose first name is before its last name alphabetically. Use LINQ query operators.


namespace _03.FirstLastNameLINQ
{
    class Testing
    {
        
        static void Main(string[] args)
        {
            Students [] arr = 
            {
                new Students("Petur", "Ivanov"),
                new Students("Ivan", "Ivanov"),
                new Students("Ivan", "Pertov"),
                
            };

            var sort = 
                from students in arr
                where students.FirstName.CompareTo(students.LastName) == -1
                select students;

            foreach (var student in sort)
            {
                Console.WriteLine("{0}, {1}", student.FirstName, student.LastName);
            }        
        }
    }
}
