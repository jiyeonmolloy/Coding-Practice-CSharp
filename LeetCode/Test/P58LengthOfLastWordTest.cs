using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P58LengthOfLastWordTest {
        [TestMethod]
        public void LengthOfLastWordTest () {
            Assert.AreEqual(5, P58LengthOfLastWord.LengthOfLastWord("Hello World"));
            Assert.AreEqual(5, P58LengthOfLastWord.LengthOfLastWord("Donut"));
            Assert.AreEqual(1, P58LengthOfLastWord.LengthOfLastWord("a"));
            Assert.AreEqual(1, P58LengthOfLastWord.LengthOfLastWord("b   a    "));
        }
    }
}
