using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public abstract class Humans : IComparable
    {
        public string firstName;
        public string lastName;

        protected Humans()
        {
        }

        protected Humans(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Humans otherHuman = obj as Humans;
            if (otherHuman != null)
            {
                if (this.FirstName.CompareTo(otherHuman.FirstName) == 0)
                {
                    return this.LastName.CompareTo(otherHuman.LastName);
                }

                return this.FirstName.CompareTo(otherHuman.FirstName);
            }
            else
            {
                throw new ArgumentException("Object is not a Human.");
            }
        }
    }
}

