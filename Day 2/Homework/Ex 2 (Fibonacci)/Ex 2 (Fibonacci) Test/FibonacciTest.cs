using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex_2__Fibonacci_;

namespace Ex_2__Fibonacci__Test
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void FibonacciSequenceTest()
        {
            Program.FibonacciSequence().Length = 5;
            string actual = Program.FibonacciSequence();
            string expected = "1,-2,3,5,-8";
            Assert.AreEqual("1,-2,3,5,-8", actual);
        }
    }
}
