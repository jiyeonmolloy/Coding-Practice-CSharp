using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1471TheKStrongestValuesInAnArrayTest {
        [TestMethod]
        public void GetStrongestElementsTest () {
            CollectionAssert.AreEqual(new int[5] { 11, 8, 6, 6, 7 }, P1471TheKStrongestValuesInAnArray.GetStrongest(new int[6] { 6, 7, 11, 7, 6, 8 }, 5));
            CollectionAssert.AreEqual(new int[2] { 5, 1 }, P1471TheKStrongestValuesInAnArray.GetStrongest(new int[5] { 1, 2, 3, 4, 5 }, 2));
            CollectionAssert.AreEqual(new int[2] { 5, 5 }, P1471TheKStrongestValuesInAnArray.GetStrongest(new int[5] { 1, 1, 3, 5, 5 }, 2));
        }
    }
}
