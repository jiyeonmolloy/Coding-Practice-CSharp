using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P1539KthMissingPositiveNumberTest {
        [TestMethod]
        public void FindKthPositiveTest () {
            Assert.AreEqual(9, P1539KthMissingPositiveNumber.FindKthPositive(new[] { 2, 3, 4, 7, 11 }, 5));
            Assert.AreEqual(6, P1539KthMissingPositiveNumber.FindKthPositive(new[] { 1, 2, 3, 4 }, 2));
        }
    }
}
