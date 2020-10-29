using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P456OneThreeTwoPatternTest {
        [TestMethod]
        public void Find132patternTest () {
            Assert.IsFalse(P456OneThreeTwoPattern.Find132pattern(new[] { 1, 2, 3, 4 }));
            Assert.IsTrue(P456OneThreeTwoPattern.Find132pattern(new[] { 3, 1, 4, 2 }));
            Assert.IsTrue(P456OneThreeTwoPattern.Find132pattern(new[] { -1, 3, 2, 0 }));
            Assert.IsTrue(P456OneThreeTwoPattern.Find132pattern(new[] { 3, 5, 0, 3, 4 }));
        }
    }
}
