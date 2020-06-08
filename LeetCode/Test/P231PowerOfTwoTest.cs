using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P231PowerOfTwoTest {
        [TestMethod]
        public void IsPowerOfTwoTest () {
            Assert.IsTrue(P231PowerOfTwo.IsPowerOfTwo(1));
            Assert.IsTrue(P231PowerOfTwo.IsPowerOfTwo(16));
            Assert.IsFalse(P231PowerOfTwo.IsPowerOfTwo(218));
            Assert.IsFalse(P231PowerOfTwo.IsPowerOfTwo(0));
        }
    }
}
