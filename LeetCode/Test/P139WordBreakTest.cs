using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P139WordBreakTest {
        [TestMethod]
        public void WordBreakTest () {
            Assert.IsTrue(P139WordBreak.WordBreak("leetcode", new[] { "leet", "code" }));
            Assert.IsTrue(P139WordBreak.WordBreak("applepenapple", new[] { "apple", "pen" }));
            Assert.IsFalse(P139WordBreak.WordBreak("catsandog", new[] { "cats", "dog", "sand", "and", "cat" }));
        }
    }
}
