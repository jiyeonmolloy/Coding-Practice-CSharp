using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1614MaximumNestingDepthOfTheParenthesesTest {
        [TestMethod]
        public void MaxDepthTest () {
            Assert.AreEqual(3, P1614MaximumNestingDepthOfTheParentheses.MaxDepth("(1+(2*3)+((8)/4))+1"));
            Assert.AreEqual(3, P1614MaximumNestingDepthOfTheParentheses.MaxDepth("(1)+((2))+(((3)))"));
            Assert.AreEqual(1, P1614MaximumNestingDepthOfTheParentheses.MaxDepth("1+(2*3)/(2-1)"));
            Assert.AreEqual(0, P1614MaximumNestingDepthOfTheParentheses.MaxDepth("1"));
        }
    }
}
