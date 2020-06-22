using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P137SingleNumberIITest {
        [TestMethod]
        public void SingleNumberTest () {
            Assert.AreEqual(3, P137SingleNumberII.SingleNumber(new int[4] { 2, 2, 3, 2 }));
            Assert.AreEqual(99, P137SingleNumberII.SingleNumber(new int[7] { 0, 1, 0, 1, 0, 1, 99 }));
        }
    }
}
