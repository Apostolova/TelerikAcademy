using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class Teachers : Human, Comments
    {
        public List<Disciplines> discipline;
        private string freeText;

        public Teachers()
        {
        }

        public Teachers(string firstName, string lastName, Disciplines discipline)
            : base(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.discipline = new List<Disciplines>();
        }

        public List<Disciplines> Discipline
        {
            get
            {
                return this.discipline;
            }
            set
            {
                this.discipline = value;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(this.FirstName);
            str.AppendLine();
            str.Append(this.LastName);
            str.AppendLine();
            str.Append(this.discipline);
            return str.ToString();
        }

        public string FreeText
        {
            get { return this.freeText; }
            set { this.freeText = value; }
        }
    }
}
