using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P290WordPatternTest {
        [TestMethod]
        public void WordPatternTest () {
            Assert.IsTrue(P290WordPattern.WordPattern("abba", "toby cat cat toby"));
            Assert.IsFalse(P290WordPattern.WordPattern("abba", "dog cat cat fish"));
            Assert.IsTrue(P290WordPattern.WordPattern("aaaa", "will will will will"));
            Assert.IsFalse(P290WordPattern.WordPattern("abba", "donut donut donut donut"));
        }
    }
}
