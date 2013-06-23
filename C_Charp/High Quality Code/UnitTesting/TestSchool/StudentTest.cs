namespace TestSchool
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolHierarchy;

    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void StudentTestConstructorName()
        {
            string name = "Pesho";
            Student student = new Student(name);
            Assert.AreEqual(student.Name, "Pesho");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "The name can not be empty!")]
        public void StudentTestNameWhenIsNull()
        {
            Student student = new Student(null);
        }

        [TestMethod]
        public void StudentTestPropertyUniqueNumber()
        {
            long uniqueNumber = 56312;
            Student student = new Student("Pesho", uniqueNumber);
            Assert.AreEqual(student.UniqueNumber, 56312);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Unique number must be range from 10000 to 99999.")]
        public void StudentTestUniqueNumberWhenIsOutOfRange()
        {
            Student student = new Student("Pesho", 563214);
        }
    }
}
