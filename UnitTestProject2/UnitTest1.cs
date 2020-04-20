using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 5, 0, -9, 5, 4, 3, -5, 0, -1 };
            int n = 9;
            string d = "2700";
            string result = ConsoleApp3._2.Program.zero(a, n);
            Assert.AreEqual(d, result);
        }
    }
}
