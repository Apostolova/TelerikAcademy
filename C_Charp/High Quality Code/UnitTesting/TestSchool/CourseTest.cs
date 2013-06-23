namespace TestSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolHierarchy;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CourseConstructorTestName()
        {
            string name = "CSharp";
            Course course = new Course(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Name of course is missing! Please enter name of course.")]
        public void NameWhenThrowExceptionNull()
        {
            Course course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Can not add student in this course, count more than 30.")]
        public void AddStudent_ThrowExceptionWhenMaxReached()
        {
            Course course = new Course("CSharp");

            for (int i = 0; i < Course.MaxStudentCount + 1; i++)
            {
                course.AddStudent(new Student("Student", i));
            }
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException), "Student with this unique number doesn't exist!")]
        public void RemoveStudent_ThrowsExceptionOnNotFound()
        {
            Course course = new Course(".NET");
            course.RemoveStudent(23);
        }
    }
}
