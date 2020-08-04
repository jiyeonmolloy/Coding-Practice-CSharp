using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P342PowerOfFourTest {
        [TestMethod]
        public void IsPowerOfFourTest () {
            Assert.IsTrue(P342PowerOfFour.IsPowerOfFour(16));
            Assert.IsFalse(P342PowerOfFour.IsPowerOfFour(5));
            Assert.IsFalse(P342PowerOfFour.IsPowerOfFour(0));
            Assert.IsTrue(P342PowerOfFour.IsPowerOfFour(1));
        }
    }
}
