using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P845LongestMountainInArrayTest {
        [TestMethod]
        public void LongestMountainTest () {
            Assert.AreEqual(5, P845LongestMountainInArray.LongestMountain(new[] { 2, 1, 4, 7, 3, 2, 5 }));
            Assert.AreEqual(7, P845LongestMountainInArray.LongestMountain(new[] { 1, 2, 3, 4, 3, 2, 1, 2, 3, 2, 1 }));
            Assert.AreEqual(11, P845LongestMountainInArray.LongestMountain(new[] { 0, 1, 2, 3, 4, 5, 4, 3, 2, 1, 0 }));
            Assert.AreEqual(4, P845LongestMountainInArray.LongestMountain(new[] { 875, 884, 239, 731, 723, 685 }));
            Assert.AreEqual(0, P845LongestMountainInArray.LongestMountain(new[] { 2, 2, 2 }));
            Assert.AreEqual(0, P845LongestMountainInArray.LongestMountain(new[] { 2, 1, 4, 7 }));
        }
    }
}
