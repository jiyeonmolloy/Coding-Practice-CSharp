using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P62UniquePathsTest {
        [TestMethod]
        public void UniquePathsTest () {
            Assert.AreEqual(3, P62UniquePaths.UniquePaths(3, 2));
            Assert.AreEqual(28, P62UniquePaths.UniquePaths(7, 3));
        }
    }
}
