using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1615MaximalNetworkRankTest {
        [TestMethod]
        public void MaximalNetworkRankTest () {
            Assert.AreEqual(4, P1615MaximalNetworkRank.MaximalNetworkRank(4, new int[][] { new[] { 0, 1 }, new[] { 0, 3 }, new[] { 1, 2 }, new[] { 1, 3 } }));
            Assert.AreEqual(5, P1615MaximalNetworkRank.MaximalNetworkRank(5, new int[][] { new[] { 0, 1 }, new[] { 0, 3 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 2, 3 }, new[] { 2, 4 } }));
            Assert.AreEqual(5, P1615MaximalNetworkRank.MaximalNetworkRank(8, new int[][] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 2, 4 }, new[] { 5, 6 }, new[] { 5, 7 } }));
        }
    }
}
