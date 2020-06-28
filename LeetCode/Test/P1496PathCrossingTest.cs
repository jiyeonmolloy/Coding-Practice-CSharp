using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1496PathCrossingTest {
        [TestMethod]
        public void IsPathCrossingTest () {
            Assert.IsFalse(P1496PathCrossing.IsPathCrossing("NES"));
            Assert.IsTrue(P1496PathCrossing.IsPathCrossing("NESWW"));
        }
    }
}
