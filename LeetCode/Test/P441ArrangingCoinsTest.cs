using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P441ArrangingCoinsTest {
        [TestMethod]
        public void ArrangeCoinsTest () {
            Assert.AreEqual(2, P441ArrangingCoins.ArrangeCoins(5));
            Assert.AreEqual(3, P441ArrangingCoins.ArrangeCoins(8));
            Assert.AreEqual(1, P441ArrangingCoins.ArrangeCoins(1));
            Assert.AreEqual(2, P441ArrangingCoins.ArrangeCoins(3));
        }
    }
}
