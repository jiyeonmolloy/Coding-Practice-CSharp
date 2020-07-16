using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P50PowXNTest {
        [TestMethod]
        public void MyPowTest () {
            Assert.AreEqual(0.00000, P50PowXN.MyPow(2.00000, -2147483648), 0.00000001);
            Assert.AreEqual(1024.00000, P50PowXN.MyPow(2.00000, 10), 0.00000001);
            Assert.AreEqual(9.26100, P50PowXN.MyPow(2.10000, 3), 0.00000001);
            Assert.AreEqual(0.25000, P50PowXN.MyPow(2.00000, -2), 0.00000001);
        }
    }
}
