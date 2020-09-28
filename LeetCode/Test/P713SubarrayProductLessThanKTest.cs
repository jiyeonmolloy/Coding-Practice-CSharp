using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P713SubarrayProductLessThanKTest {
        [TestMethod]
        public void NumSubarrayProductLessThanKTest () {
            Assert.AreEqual(8, P713SubarrayProductLessThanK.NumSubarrayProductLessThanK(new[] { 10, 5, 2, 6 }, 100));
            Assert.AreEqual(0, P713SubarrayProductLessThanK.NumSubarrayProductLessThanK(new[] { 1, 2, 3 }, 0));
            Assert.AreEqual(0, P713SubarrayProductLessThanK.NumSubarrayProductLessThanK(new[] { 1, 1, 1 }, 1));
        }
    }
}
