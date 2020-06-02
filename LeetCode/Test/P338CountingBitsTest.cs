using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P338CountingBitsTest {
        [TestMethod]
        public void CountBitsTest () {
            CollectionAssert.AreEqual(new int[3] { 0, 1, 1 }, P338CountingBits.CountBits(2));
            CollectionAssert.AreEqual(new int[6] { 0, 1, 1, 2, 1, 2 }, P338CountingBits.CountBits(5));
        }
    }
}
