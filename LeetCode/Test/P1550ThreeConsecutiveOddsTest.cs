using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1550ThreeConsecutiveOddsTest {
        [TestMethod]
        public void ThreeConsecutiveOddsTest () {
            Assert.IsFalse(P1550ThreeConsecutiveOdds.ThreeConsecutiveOdds(new int[4] { 2, 6, 4, 1 }));
            Assert.IsTrue(P1550ThreeConsecutiveOdds.ThreeConsecutiveOdds(new int[9] { 1, 2, 34, 3, 4, 5, 7, 23, 12 }));
        }
    }
}
