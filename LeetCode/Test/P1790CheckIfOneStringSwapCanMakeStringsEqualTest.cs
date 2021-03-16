using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P1790CheckIfOneStringSwapCanMakeStringsEqualTest {
        [TestMethod]
        public void AreAlmostEqualTest () {
            Assert.IsFalse(P1790CheckIfOneStringSwapCanMakeStringsEqual.AreAlmostEqual("abce", "dbca"));
            Assert.IsFalse(P1790CheckIfOneStringSwapCanMakeStringsEqual.AreAlmostEqual("abcd", "baec"));
            Assert.IsTrue(P1790CheckIfOneStringSwapCanMakeStringsEqual.AreAlmostEqual("bank", "kanb"));
            Assert.IsTrue(P1790CheckIfOneStringSwapCanMakeStringsEqual.AreAlmostEqual("kelb", "kelb"));
            Assert.IsFalse(P1790CheckIfOneStringSwapCanMakeStringsEqual.AreAlmostEqual("abcd", "dcba"));
            Assert.IsFalse(P1790CheckIfOneStringSwapCanMakeStringsEqual.AreAlmostEqual("attack", "defend"));
            Assert.IsFalse(P1790CheckIfOneStringSwapCanMakeStringsEqual.AreAlmostEqual("a", "d"));
            Assert.IsTrue(P1790CheckIfOneStringSwapCanMakeStringsEqual.AreAlmostEqual("a", "a"));
            Assert.IsFalse(P1790CheckIfOneStringSwapCanMakeStringsEqual.AreAlmostEqual("ab", "ad"));
        }
    }
}
