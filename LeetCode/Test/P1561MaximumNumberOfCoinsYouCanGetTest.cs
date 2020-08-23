using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1561MaximumNumberOfCoinsYouCanGetTest {
        [TestMethod]
        public void MaxCoinsTest () {
            Assert.AreEqual(18, P1561MaximumNumberOfCoinsYouCanGet.MaxCoins(new int[9] { 9, 8, 7, 6, 5, 1, 2, 3, 4 }));
            Assert.AreEqual(9, P1561MaximumNumberOfCoinsYouCanGet.MaxCoins(new int[6] { 2, 4, 1, 2, 7, 8 }));
            Assert.AreEqual(4, P1561MaximumNumberOfCoinsYouCanGet.MaxCoins(new int[3] { 2, 4, 5 }));
        }
    }
}
