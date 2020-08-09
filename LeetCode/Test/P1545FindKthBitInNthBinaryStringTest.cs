using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1545FindKthBitInNthBinaryStringTest {
        [TestMethod]
        public void FindKthBitTest () {
            Assert.AreEqual('0', P1545FindKthBitInNthBinaryString.FindKthBit(3, 1));
            Assert.AreEqual('1', P1545FindKthBitInNthBinaryString.FindKthBit(4, 11));
            Assert.AreEqual('0', P1545FindKthBitInNthBinaryString.FindKthBit(1, 1));
            Assert.AreEqual('1', P1545FindKthBitInNthBinaryString.FindKthBit(2, 3));
        }
    }
}
