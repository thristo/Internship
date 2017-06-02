using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex_1;

namespace Exercise1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()

        {
           uint firstDecimalTest = 12;
           uint secondDecimalTest = 18;
           int expected = 4;
           int actual = MathProblems.SumBinaryRepresentations(firstDecimalTest, secondDecimalTest);
           Assert.AreEqual(expected, actual, 0.001, "Fail");                
        }



        [TestMethod]
        public void TestMethod2()
        {
            uint firstDecimalTest2 = 15;
            uint secondDecimalTest2 = 20;
            uint thirdDecimalTest = 23;
            int expectedSecond = 10;
            int actualSecond = MathProblems.SumBinaryRepresentationsOfThree(firstDecimalTest2, secondDecimalTest2, thirdDecimalTest);
            Assert.AreEqual(expectedSecond, actualSecond, 0.001, "Fail");
        }


    }
}
