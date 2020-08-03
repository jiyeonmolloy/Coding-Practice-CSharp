using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P125ValidPalindromeTest {
        [TestMethod]
        public void IsPalindromeTest () {
            Assert.IsTrue(P125ValidPalindrome.IsPalindrome("A man, a plan, a canal: Panama"));
            Assert.IsFalse(P125ValidPalindrome.IsPalindrome("race a car"));
        }
    }
}
