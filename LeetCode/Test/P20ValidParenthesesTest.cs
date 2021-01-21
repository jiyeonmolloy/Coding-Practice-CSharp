using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P20ValidParenthesesTest {
        [TestMethod]
        public void IsValidTest () {
            Assert.IsTrue(P20ValidParentheses.IsValid("()"));
            Assert.IsTrue(P20ValidParentheses.IsValid("()[]{}"));
            Assert.IsFalse(P20ValidParentheses.IsValid("(]"));
            Assert.IsFalse(P20ValidParentheses.IsValid("([)]"));
            Assert.IsTrue(P20ValidParentheses.IsValid("{[]}"));
        }
    }
}
