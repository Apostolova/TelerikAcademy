using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class Classes : Comments
    {
        public string name;
        public List<Students> student;
        public List<Teachers> teacher;
        private string freeText;

        public Classes(string name)
        {
            this.name = name;
        }

        public Classes(string name, List<Students> student, List<Teachers> teacher)
        {
            this.name = name;
            this.student = new List<Students>();
            this.teacher = new List<Teachers>();
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(this.student);
            str.Append(this.teacher);
            return str.ToString();
        }

        public string FreeText
        {
            get { return this.freeText; }
            set { this.freeText = value; }
        }

    }
}
