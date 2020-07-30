using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P121BestTimeToBuyAndSellStockTest {
        [TestMethod]
        public void MaxProfitTest () {
            Assert.AreEqual(5, P121BestTimeToBuyAndSellStock.MaxProfit(new int[6] { 7, 1, 5, 3, 6, 4 }));
            Assert.AreEqual(0, P121BestTimeToBuyAndSellStock.MaxProfit(new int[5] { 7, 6, 4, 3, 1 }));
            Assert.AreEqual(0, P121BestTimeToBuyAndSellStock.MaxProfit(new int[1] { 7 }));
        }
    }
}
