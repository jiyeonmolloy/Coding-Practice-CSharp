using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P190ReverseBitsTest {
        [TestMethod]
        public void ReverseBitsTest () {
            Assert.AreEqual((uint)964176192, P190ReverseBits.ReverseBits(43261596));
            Assert.AreEqual(3221225471, P190ReverseBits.ReverseBits(4294967293));
        }
    }
}
