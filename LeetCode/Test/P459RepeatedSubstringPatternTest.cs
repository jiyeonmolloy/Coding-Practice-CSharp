using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P459RepeatedSubstringPatternTest {
        [TestMethod]
        public void RepeatedSubstringPatternTest () {
            Assert.IsTrue(P459RepeatedSubstringPattern.RepeatedSubstringPattern("abab"));
            Assert.IsTrue(P459RepeatedSubstringPattern.RepeatedSubstringPattern("tobytobytoby"));
            Assert.IsFalse(P459RepeatedSubstringPattern.RepeatedSubstringPattern("tobies"));
        }
    }
}
