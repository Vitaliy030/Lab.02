using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 1.25;
            double y = Math.Pow(x, 1.0 / 4.0);
            double result = ConsoleApp2._1.Program.Calculation(x);
            Assert.AreEqual(y, result);
        }
    }
}
