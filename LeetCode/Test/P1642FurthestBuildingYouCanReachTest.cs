using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1642FurthestBuildingYouCanReachTest {
        [TestMethod]
        public void FurthestBuildingTest () {
            Assert.AreEqual(4, P1642FurthestBuildingYouCanReach.FurthestBuilding(new[] { 4, 2, 7, 6, 9, 14, 12 }, 5, 1));
            Assert.AreEqual(7, P1642FurthestBuildingYouCanReach.FurthestBuilding(new[] { 4, 12, 2, 7, 3, 18, 20, 3, 19 }, 10, 2));
            Assert.AreEqual(3, P1642FurthestBuildingYouCanReach.FurthestBuilding(new[] { 14, 3, 19, 3 }, 17, 0));
            Assert.AreEqual(2, P1642FurthestBuildingYouCanReach.FurthestBuilding(new[] { 1, 2, 3, 4 }, 1, 1));
            Assert.AreEqual(5, P1642FurthestBuildingYouCanReach.FurthestBuilding(new[] { 1, 61, 62, 63, 64, 65 }, 60, 1));
        }
    }
}
