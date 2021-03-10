using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P1785MinimumElementsToAddToFormAGivenSumTest {
        [TestMethod]
        public void MinElementstTest () {
            Assert.AreEqual(2, P1785MinimumElementsToAddToFormAGivenSum.MinElements(new[] { 1, -1, 1 }, 3, -4));
            Assert.AreEqual(1, P1785MinimumElementsToAddToFormAGivenSum.MinElements(new[] { 1, -10, 9, 1 }, 100, 0));
            Assert.AreEqual(25322847, P1785MinimumElementsToAddToFormAGivenSum.MinElements(new[] { 2, 2, 5, 1, -2 }, 5, 126614243));
        }
    }
}
