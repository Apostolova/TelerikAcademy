namespace TestSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolHierarchy;
    using System.Collections.Generic;

    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void AddCourseTest()
        {
            List<Course> courses = new List<Course>();
            Course csharp = new Course("CSharp");
            School school = new School(courses);
            school.AddCourse(csharp);
            Assert.AreEqual(csharp.NameCourse, school.Courses[0].NameCourse);
        }

        [TestMethod]
        public void RemoveCourses()
        {
            List<Course> courses = new List<Course>();
            Course csharp = new Course("CSharp");
            School school = new School(courses);
            school.AddCourse(csharp);
            school.RemoveCourse("CSharp");
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException), "A course with the specified name doesn't exist!")]
        public void RemoveCoursesIfNotExist()
        {
            List<Course> courses = new List<Course>();
            School school = new School(courses);
            Course javascript = new Course("Javascript");
            school.RemoveCourse("javascript");
        }
    }
}
