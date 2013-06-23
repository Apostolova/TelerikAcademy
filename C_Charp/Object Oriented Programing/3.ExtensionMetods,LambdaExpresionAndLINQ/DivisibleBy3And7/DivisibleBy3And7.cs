using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.


namespace DivisibleBy3And7
{
    class DivisibleBy3And7
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>{ 5, 12, 21, 27, 42, 8 };

            Console.WriteLine("Lambda expresion");
            var divisble = (numbers.FindAll(x => (x % 7 == 0)&&(x % 3 ==0)));
            foreach (var item in divisble)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("LINQ");

            var divisibleLINQ = 
                from number in numbers
                where (number % 21) == 0
                select number;

            foreach (var number in divisibleLINQ)
            {
                Console.WriteLine(number);
            }

        }
    }
}
