using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P9PalindromeNumberTest {
        [TestMethod]
        public void IsPalindromeTest () {
            Assert.IsTrue(P9PalindromeNumber.IsPalindrome(121));
            Assert.IsTrue(P9PalindromeNumber.IsPalindrome(1221));
            Assert.IsFalse(P9PalindromeNumber.IsPalindrome(-121));
            Assert.IsFalse(P9PalindromeNumber.IsPalindrome(10));
        }
    }
}
