using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P394DecodeStringTest {
        [TestMethod]
        public void DecodeStringTest () {
            Assert.AreEqual("aaabcbc", P394DecodeString.DecodeString("3[a]2[bc]"));
            Assert.AreEqual("accaccacc", P394DecodeString.DecodeString("3[a2[c]]"));
            Assert.AreEqual("abcabccdcdcdef", P394DecodeString.DecodeString("2[abc]3[cd]ef"));
            Assert.AreEqual("abccdcdcdxyz", P394DecodeString.DecodeString("abc3[cd]xyz"));
        }
    }
}
