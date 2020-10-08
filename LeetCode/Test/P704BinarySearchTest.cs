using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P704BinarySearchTest {
        [TestMethod]
        public void SearchTest () {
            Assert.AreEqual(4, P704BinarySearch.Search(new[] { -1, 0, 3, 5, 9, 12 }, 9));
            Assert.AreEqual(-1, P704BinarySearch.Search(new[] { 3, 5 }, 2));
        }
    }
}
