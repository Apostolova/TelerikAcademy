namespace SchoolHierarchy
{
    using System;
    using System.Linq;

  public class Student
    {
        private string name;
        private long uniqueNumber;

        public Student(string name)
        {
            this.Name = name;
        }

        public Student(string name, long uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == string.Empty || value == null)
                {
                    throw new ArgumentNullException("The name can not be empty!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public long UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }

            set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("Unique number must be range from 10000 to 99999.");
                }
                else
                {
                    this.uniqueNumber = value;
                }
            }
        }
    }
}
