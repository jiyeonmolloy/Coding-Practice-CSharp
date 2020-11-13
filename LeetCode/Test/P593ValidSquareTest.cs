using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P593ValidSquareTest {
        [TestMethod]
        public void ValidSquareTest () {
            Assert.IsTrue(P593ValidSquare.ValidSquare(new[] { 0, 0 }, new[] { 1, 1 }, new[] { 1, 0 }, new[] { 0, 1 }));
            Assert.IsFalse(P593ValidSquare.ValidSquare(new[] { 0, 0 }, new[] { 2, 2 }, new[] { 1, 0 }, new[] { 0, 1 }));
        }
    }
}
