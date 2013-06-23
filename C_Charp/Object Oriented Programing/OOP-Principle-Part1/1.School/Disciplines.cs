using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class Disciplines : Comments
    {
        public string name;
        public int numberOfLecture;
        public int NumberOfExercises { get; set; }
        private string freeText;

        public Disciplines()
        {
        }

        public Disciplines(string name, int numberOfLecture, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLecture = numberOfLecture;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int NumberOfLecture
        {
            get
            {
                return this.numberOfLecture;
            }
            set
            {
                if (value > 50)
                    throw new ArgumentException("Incorrect numbers");
                else
                    this.numberOfLecture = value;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(this.Name);
            str.AppendLine();
            str.Append(this.NumberOfLecture);
            str.AppendLine();
            str.Append(this.NumberOfExercises);
            str.AppendLine();
            return str.ToString();
        }

        public string FreeText
        {
            get { return this.freeText; }
            set { this.freeText = value; }
        }
    }
}
