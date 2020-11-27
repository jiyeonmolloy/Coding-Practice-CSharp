using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P1015SmallestIntegerDivisibleByKTest {
        [TestMethod]
        public void SmallestRepunitDivByKTest () {
            Assert.AreEqual(1, P1015SmallestIntegerDivisibleByK.SmallestRepunitDivByK(1));
            Assert.AreEqual(-1, P1015SmallestIntegerDivisibleByK.SmallestRepunitDivByK(2));
            Assert.AreEqual(3, P1015SmallestIntegerDivisibleByK.SmallestRepunitDivByK(3));
        }
    }
}
