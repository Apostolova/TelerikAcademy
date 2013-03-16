using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
  public  class Student : Humans
    {
        public string Grade { get; set; }

       
        public Student(string firstName, string lastName, string grade)
            : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
    }
}
