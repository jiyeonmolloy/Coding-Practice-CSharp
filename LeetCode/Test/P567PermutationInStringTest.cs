using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P567PermutationInStringTest {
        [TestMethod]
        public void PermutationInString () {
            string s1 = "ab";
            string s2 = "eidbaooo";

            Assert.IsTrue(P567PermutationInString.CheckInclusion(s1, s2));

            s1 = "ab";
            s2 = "eidboaoo";

            Assert.IsFalse(P567PermutationInString.CheckInclusion(s1, s2));
        }
    }
}
