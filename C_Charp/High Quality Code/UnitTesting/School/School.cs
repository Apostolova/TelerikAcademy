namespace SchoolHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        public List<Course> Courses { get; set; }

        public School(List<Course> courses = null)
        {
            this.Courses = new List<Course>();
        }

         public void AddCourse(Course newCourse)
        {
            if (newCourse == null)
            {
                throw new ArgumentNullException("Course cannot be null!");
            }

            this.Courses.Add(newCourse);
        }

        public void RemoveCourse(string courseName)
        {
            for (int i = 0; i < this.Courses.Count; i++)
            {
                if (this.Courses[i].NameCourse == courseName)
                {
                    this.Courses.RemoveAt(i);
                    return;
                }
            }

            throw new KeyNotFoundException("A course with the specified name doesn't exist!");
        }
    }
}
