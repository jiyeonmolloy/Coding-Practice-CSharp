using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P189RotateArrayTest {
        [TestMethod]
        public void RotateTest () {
            CollectionAssert.AreEqual(new[] { 5, 6, 7, 1, 2, 3, 4 }, P189RotateArray.Rotate(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3));
            CollectionAssert.AreEqual(new[] { 3, 99, -1, -100 }, P189RotateArray.Rotate(new[] { -1, -100, 3, 99 }, 2));
        }
    }
}
