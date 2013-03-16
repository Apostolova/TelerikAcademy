using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School
{
    public class Students : Human, Comments
    {

        public long UniqueClassNumber { get; set; }
        private string freeText;

        public Students()
        {
        }

        public Students(string firstName, string lastName, long uniqueClassNumber)
            : base(firstName, lastName)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(this.FirstName);
            str.AppendLine();
            str.Append(this.LastName);
            str.AppendLine();
            str.Append(this.UniqueClassNumber);
            return str.ToString();
        }

        public string FreeText
        {
            get { return this.freeText; }
            set { this.freeText = value; }
        }
    }
}
