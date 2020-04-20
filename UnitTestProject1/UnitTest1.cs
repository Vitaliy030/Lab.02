using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 5, 4, -9, 5, 4, 3, -5, 2, -1 };
            int n = 9;
            int min = -1;
            double result = ConsoleApp3._2.Program.min_element(a, n);
            Assert.AreEqual(min, result);
        }
    }
}
