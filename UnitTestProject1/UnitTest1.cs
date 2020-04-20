using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] a = { { 5, 4, -9 }, { 5, 4, 3 }, {-5, 2, -1 } };
            int p1 = 1;
            int t1 = 1;
            int p2 = 2;
            int t2 = 0;
            int d = 4 * (-5);
            int result = ConsoleApp5._1.Program.product(a, p1, t1, p2, t2);
            Assert.AreEqual(d, result);
        }
    }
}
