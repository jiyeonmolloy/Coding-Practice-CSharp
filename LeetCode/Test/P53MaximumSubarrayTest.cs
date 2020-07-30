using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P53MaximumSubarrayTest {
        [TestMethod]
        public void MaxSubArrayTest () {
            Assert.AreEqual(5, P53MaximumSubarray.MaxSubArray(new int[4] { -2, 3, 2, -1 }));
            Assert.AreEqual(6, P53MaximumSubarray.MaxSubArray(new int[9] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }
    }
}
