using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P520DetectCapitalTest {
        [TestMethod]
        public void DetectCapitalTest () {
            Assert.IsTrue(P520DetectCapital.DetectCapitalUse("TOBY"));
            Assert.IsTrue(P520DetectCapital.DetectCapitalUse("leetcode"));
            Assert.IsFalse(P520DetectCapital.DetectCapitalUse("FlaG"));
            Assert.IsTrue(P520DetectCapital.DetectCapitalUse("Tobies"));
        }
    }
}
