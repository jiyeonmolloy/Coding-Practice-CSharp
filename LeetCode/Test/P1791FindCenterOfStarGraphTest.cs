using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P1791FindCenterOfStarGraphTest {
        [TestMethod]
        public void FindCenterTest () {
            Assert.AreEqual(2, P1791FindCenterOfStarGraph.FindCenter(new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 4, 2 } }));
            Assert.AreEqual(1, P1791FindCenterOfStarGraph.FindCenter(new int[][] { new int[] { 1, 2 }, new int[] { 5, 1 }, new int[] { 1, 3 } }));
        }
    }
}
