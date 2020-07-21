using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1518WaterBottlesTest {
        [TestMethod]
        public void NumWaterBottlesTest () {
            Assert.AreEqual(13, P1518WaterBottles.NumWaterBottles(9, 3));
            Assert.AreEqual(19, P1518WaterBottles.NumWaterBottles(15, 4));
            Assert.AreEqual(6, P1518WaterBottles.NumWaterBottles(5, 5));
            Assert.AreEqual(2, P1518WaterBottles.NumWaterBottles(2, 3));
        }
    }
}
