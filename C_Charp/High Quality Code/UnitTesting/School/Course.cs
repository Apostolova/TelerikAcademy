namespace SchoolHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class Course
    {
        public const int MaxStudentCount = 29;
        private List<Student> students;
        private string nameCourse;

        public Course(string nameCourse)
        {
            this.NameCourse = nameCourse;
        }

        public string NameCourse
        {
            get
            {
                return this.nameCourse;
            }

            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("Name of course is missing! Please enter name of course.");
                }
                else
                {
                    this.nameCourse = value;
                }
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                if (value.Count > MaxStudentCount)
                {
                    throw new ArgumentOutOfRangeException("Students in a course should be less than 30.");
                }
                else
                {
                    this.students = value;
                }
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Value should not be null.");
            }

            if (this.Students.Count == MaxStudentCount)
            {
                throw new ArgumentOutOfRangeException("Can not add student in this course, count more than 30.");
            }
            else
            {
                this.Students.Add(student);
            }
        }

        public void RemoveStudent(int uniqueNumber)
        {
            for (int i = 0; i < this.Students.Count; i++)
            {
                if (this.students[i].UniqueNumber == uniqueNumber)
                {
                    this.Students.RemoveAt(i);
                    return;
                }
            }

            throw new NullReferenceException("Student with this unique number doesn't exist!");
        }
    }
}
