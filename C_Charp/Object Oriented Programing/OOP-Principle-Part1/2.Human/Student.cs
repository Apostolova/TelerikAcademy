using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
  public  class Student : Humans
    {
        public byte Grade { get; set; }

        public Student()
        {
        }
       
        public Student(string firstName, string lastName, byte grade)
            : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(this.firstName + " ");
            str.Append(this.lastName + " ");
            str.Append(this.Grade);
            return str.ToString();
        }
    }
}
