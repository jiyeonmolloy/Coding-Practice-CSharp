using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1512NumberOfGoodPairsTest {
        [TestMethod]
        public void NumIdenticalPairsTest () {
            Assert.AreEqual(4, P1512NumberOfGoodPairs.NumIdenticalPairs(new int[6] { 1, 2, 3, 1, 1, 3 }));
            Assert.AreEqual(6, P1512NumberOfGoodPairs.NumIdenticalPairs(new int[4] { 1, 1, 1, 1 }));
            Assert.AreEqual(0, P1512NumberOfGoodPairs.NumIdenticalPairs(new int[3] { 1, 2, 3 }));
        }
    }
}
