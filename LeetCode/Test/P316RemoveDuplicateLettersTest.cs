using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P316RemoveDuplicateLettersTest {
        [TestMethod]
        public void RemoveDuplicateLettersTest () {
            Assert.AreEqual("abc", P316RemoveDuplicateLetters.RemoveDuplicateLetters("bcabc"));
            Assert.AreEqual("acdb", P316RemoveDuplicateLetters.RemoveDuplicateLetters("cbacdcbc"));
        }
    }
}
