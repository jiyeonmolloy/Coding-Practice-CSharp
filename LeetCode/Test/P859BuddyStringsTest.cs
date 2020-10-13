using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P859BuddyStringsTest {
        [TestMethod]
        public void BuddyStringsTest () {
            Assert.IsTrue(P859BuddyStrings.BuddyStrings("ab", "ba"));
            Assert.IsFalse(P859BuddyStrings.BuddyStrings("ab", "ab"));
            Assert.IsTrue(P859BuddyStrings.BuddyStrings("aa", "aa"));
            Assert.IsTrue(P859BuddyStrings.BuddyStrings("aaaaaaabc", "aaaaaaacb"));
            Assert.IsFalse(P859BuddyStrings.BuddyStrings("", "aa"));
        }
    }
}
