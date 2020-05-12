using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P540SingleElementInASortedArrayTest {
        [TestMethod]
        public void FindSingleElementInASortedArray () {
            int[] test = new int[9] { 1, 1, 2, 3, 3, 4, 4, 8, 8 };
            Assert.AreEqual(2, P540SingleElementInASortedArray.SingleNonDuplicate(test));

            test = new int[7] { 3, 3, 7, 7, 10, 11, 11 };
            Assert.AreEqual(10, P540SingleElementInASortedArray.SingleNonDuplicate(test));
        }
    }
}
