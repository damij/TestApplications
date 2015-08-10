using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppveyorTest;

namespace ApveyorTestUT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestClass tc = new TestClass();
            Console.WriteLine("Test Executed: " + tc.TestString);
        }
    }
}
