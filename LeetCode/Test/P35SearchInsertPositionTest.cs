using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P35SearchInsertPositionTest {
        [TestMethod]
        public void SearchInsertTest () {
            Assert.AreEqual(2, P35SearchInsertPosition.SearchInsert(new int[4] { 1, 3, 5, 6 }, 5));
            Assert.AreEqual(1, P35SearchInsertPosition.SearchInsert(new int[4] { 1, 3, 5, 6 }, 2));
            Assert.AreEqual(4, P35SearchInsertPosition.SearchInsert(new int[4] { 1, 3, 5, 6 }, 7));
            Assert.AreEqual(2, P35SearchInsertPosition.SearchInsert(new int[4] { 1, 3, 5, 6 }, 4));
            Assert.AreEqual(0, P35SearchInsertPosition.SearchInsert(new int[4] { 1, 3, 5, 6 }, 0));
        }
    }
}
