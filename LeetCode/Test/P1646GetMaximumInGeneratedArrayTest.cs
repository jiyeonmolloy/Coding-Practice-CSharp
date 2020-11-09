using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1646GetMaximumInGeneratedArrayTest {
        [TestMethod]
        public void GetMaximumGeneratedTest () {
            Assert.AreEqual(3, P1646GetMaximumInGeneratedArray.GetMaximumGenerated(7));
            Assert.AreEqual(1, P1646GetMaximumInGeneratedArray.GetMaximumGenerated(2));
            Assert.AreEqual(2, P1646GetMaximumInGeneratedArray.GetMaximumGenerated(3));
        }
    }
}
