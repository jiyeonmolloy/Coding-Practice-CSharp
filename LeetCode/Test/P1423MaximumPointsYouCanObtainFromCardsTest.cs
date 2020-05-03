using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1423MaximumPointsYouCanObtainFromCardsTest {
        [TestMethod]
        public void MaximuPointsObtainedFromCards () {
            int[] test = new int[7] { 1, 2, 3, 4, 5, 6, 1 };
            Assert.AreEqual(12, P1423MaximumPointsYouCanObtainFromCards.MaxScore(test, 3));

            test = new int[3] { 2, 2, 2 };
            Assert.AreEqual(4, P1423MaximumPointsYouCanObtainFromCards.MaxScore(test, 2));

            test = new int[8] { 1, 400, 1, 1, 1, 1, 200, 1 };
            Assert.AreEqual(402, P1423MaximumPointsYouCanObtainFromCards.MaxScore(test, 3));
        }
    }
}
