using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P287FindTheDuplicateNumberTest {
        [TestMethod]
        public void FindDuplicateTest () {
            Assert.AreEqual(2, P287FindTheDuplicateNumber.FindDuplicate(new int[5] { 1, 3, 4, 2, 2 }));
            Assert.AreEqual(3, P287FindTheDuplicateNumber.FindDuplicate(new int[5] { 3, 1, 3, 4, 2 }));
            Assert.AreEqual(9, P287FindTheDuplicateNumber.FindDuplicate(new int[10] { 2, 5, 9, 6, 9, 3, 8, 9, 7, 1 })); // Duplicate number is 7?
        }
    }
}
