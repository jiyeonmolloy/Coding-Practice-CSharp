using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P5454LeastNumberOfUniqueIntegersAfterKRemovalsTest {
        [TestMethod]
        public void FindLeastNumOfUniqueIntsTest () {
            Assert.AreEqual(1, P5454LeastNumberOfUniqueIntegersAfterKRemovals.FindLeastNumOfUniqueInts(new int[3] { 5, 5, 4 }, 1));
            Assert.AreEqual(2, P5454LeastNumberOfUniqueIntegersAfterKRemovals.FindLeastNumOfUniqueInts(new int[7] { 4, 3, 1, 1, 3, 3, 2 }, 3));
        }
    }
}
