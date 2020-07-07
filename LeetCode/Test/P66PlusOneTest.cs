using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P66PlusOneTest {
        [TestMethod]
        public void PlusOneTest () {
            CollectionAssert.AreEqual(new int[3] { 1, 2, 4 }, P66PlusOne.PlusOne(new int[3] { 1, 2, 3 }));
            CollectionAssert.AreEqual(new int[4] { 4, 3, 2, 2 }, P66PlusOne.PlusOne(new int[4] { 4, 3, 2, 1 }));
            CollectionAssert.AreEqual(new int[5] { 1, 0, 0, 0, 0 }, P66PlusOne.PlusOne(new int[4] { 9, 9, 9, 9 }));
        }
    }
}
