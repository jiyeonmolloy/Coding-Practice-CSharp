using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1695MaximumErasureValueTest {
        [TestMethod]
        public void MaximumUniqueSubarrayTest () {
            Assert.AreEqual(2, P1695MaximumErasureValue.MaximumUniqueSubarray(new int[] { 2 }));
            Assert.AreEqual(17, P1695MaximumErasureValue.MaximumUniqueSubarray(new int[] { 4, 2, 4, 5, 6 }));
            Assert.AreEqual(8, P1695MaximumErasureValue.MaximumUniqueSubarray(new int[] { 5, 2, 1, 2, 5, 2, 1, 2, 5 }));
            Assert.AreEqual(10001, P1695MaximumErasureValue.MaximumUniqueSubarray(new int[] { 10000, 1, 10000, 1, 1, 1, 1, 1, 1 }));
        }
    }
}
