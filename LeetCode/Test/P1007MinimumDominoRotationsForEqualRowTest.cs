using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1007MinimumDominoRotationsForEqualRowTest {
        [TestMethod]
        public void MinDominoRotationsTest () {
            Assert.AreEqual(2, P1007MinimumDominoRotationsForEqualRow.MinDominoRotations(new[] { 2, 1, 2, 4, 2, 2 }, new[] { 5, 2, 6, 2, 3, 2 }));
            Assert.AreEqual(-1, P1007MinimumDominoRotationsForEqualRow.MinDominoRotations(new[] { 3, 5, 1, 2, 3 }, new[] { 3, 6, 3, 3, 4 }));
        }
    }
}
