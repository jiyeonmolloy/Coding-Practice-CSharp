using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1616SplitTwoStringsToMakePalindromeTest {
        [TestMethod]
        public void CheckPalindromeFormationTest () {
            Assert.IsTrue(P1616SplitTwoStringsToMakePalindrome.CheckPalindromeFormation("x", "y"));
            Assert.IsTrue(P1616SplitTwoStringsToMakePalindrome.CheckPalindromeFormation("abdef", "fecab"));
            Assert.IsTrue(P1616SplitTwoStringsToMakePalindrome.CheckPalindromeFormation("ulacfd", "jizalu"));
            Assert.IsTrue(P1616SplitTwoStringsToMakePalindrome.CheckPalindromeFormation("pvhmupgqeltozftlmfjjde", "yjgpzbezspnnpszebzmhvp"));
            Assert.IsFalse(P1616SplitTwoStringsToMakePalindrome.CheckPalindromeFormation("xbdef", "xecab"));
        }
    }
}
