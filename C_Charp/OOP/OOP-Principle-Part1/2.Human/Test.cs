using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
   public class Test
    {
       static void Main()
       {
           List<Student> students = new List<Student>() { };
           students.Add(new Student("Ivan", "Ivanov", 5));
           students.Add(new Student("Ivan", "Petrov", 5));
           students.Add(new Student("Petur", "Ivanov", 6));
           students.Add(new Student("Ivanka", "Ivanova", 4));
           students.Add(new Student("Vania", "Ivanova", 12));
           students.Add(new Student("Ivancho", "Ivanov", 10));
           students.Add(new Student("Ivanko", "Ivanov", 5));
           students.Add(new Student("Ivan", "Georgiev", 12));
           students.Add(new Student("Ivan", "Dimitrov", 10));
           students.Add(new Student("Ivan", "Popov", 6));

           students.Sort(new Comparison<Student>((s1, s2) => s1.Grade.CompareTo(s2.Grade)));

           students = students.OrderBy(s => s.Grade).ToList();
           var sortedByGrade =
           (from student in students
            orderby student.Grade
            select student).ToList();

           foreach (Student item in sortedByGrade)
           {
               Console.WriteLine(item.ToString());
           }

           Console.WriteLine();

           List<Worker> workers = new List<Worker>() { };
           workers.Add(new Worker("Ivan", "Ivanov", 250, 40));
           workers.Add(new Worker("Ivan", "Petrov", 260, 20));
           workers.Add(new Worker("Petur", "Ivanov", 350, 40));
           workers.Add(new Worker("Ivanka", "Ivanova", 220, 40));
           workers.Add(new Worker("Vania", "Ivanova", 200, 30));
           workers.Add(new Worker("Ivancho", "Ivanov", 250, 40));
           workers.Add(new Worker("Ivanko", "Ivanov", 250, 40));
           workers.Add(new Worker("Ivan", "Georgiev", 290, 40));
           workers.Add(new Worker("Ivan", "Dimitrov", 240, 38));
           workers.Add(new Worker("Ivan", "Popov", 450, 50));


           var ByMoney = workers.OrderByDescending(x => x.MoneyPerHour());
           foreach (Worker item in ByMoney)
           {
               Console.WriteLine(item.firstName, item.lastName);
           }

           List<Humans> human = new List<Humans>(students);
           List<Humans> humanWorkers = new List<Humans>(workers);

           human = human.Concat(humanWorkers).ToList();
           human = human.OrderBy(h => h.FirstName).ThenBy(h => h.LastName).ToList();

           human.Sort();

          var SortedHumans =
           (from Humans in human
            orderby Humans.firstName, Humans.LastName
            select Humans).ToList();

           foreach (var Humans in SortedHumans)
           {
               Console.WriteLine(Humans);
           }
         
       }

    }
}
