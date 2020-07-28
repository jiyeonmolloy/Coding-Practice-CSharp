using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P258AddDigitsTest {
        [TestMethod]
        public void AddDigitsTest () {
            Assert.AreEqual(2, P258AddDigits.AddDigits(101));
        }
    }
}
