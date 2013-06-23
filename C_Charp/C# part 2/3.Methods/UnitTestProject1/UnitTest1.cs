using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberInArray;



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            Program.CountTimesNumberAppears(5, arr);
            int [] arr = new int[] {1, 5, 6, 5, 5, 1, 5};
            
        }

       
    }
}
