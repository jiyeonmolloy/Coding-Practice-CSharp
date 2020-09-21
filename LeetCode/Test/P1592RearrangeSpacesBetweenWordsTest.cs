using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1592RearrangeSpacesBetweenWordsTest {
        [TestMethod]
        public void ReorderSpacesTest () {
            Assert.AreEqual("this   is   a   sentence", P1592RearrangeSpacesBetweenWords.ReorderSpaces("  this   is  a sentence "));
            Assert.AreEqual("practice   makes   perfect ", P1592RearrangeSpacesBetweenWords.ReorderSpaces(" practice   makes   perfect"));
            Assert.AreEqual("hello   world", P1592RearrangeSpacesBetweenWords.ReorderSpaces("hello   world"));
            Assert.AreEqual("a", P1592RearrangeSpacesBetweenWords.ReorderSpaces("a"));
            Assert.AreEqual("a   ", P1592RearrangeSpacesBetweenWords.ReorderSpaces("  a "));
        }
    }
}
