using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1TwoSumTest {
        [TestMethod]
        public void TwoSumTest () {
            CollectionAssert.AreEqual(new int[2] { 0, 1 }, P1TwoSum.TwoSum(new int[4] { 2, 7, 11, 15 }, 9));
        }
    }
}
