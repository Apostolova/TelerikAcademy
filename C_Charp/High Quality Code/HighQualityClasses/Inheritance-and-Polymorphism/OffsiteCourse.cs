namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        public string Town { get; set; }

        public OffsiteCourse(string name, string teacherName, IList<string> students, string town = null) 
            : base (name, teacherName, students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
            this.Town = null;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Local{0}", base.ToString());

            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
