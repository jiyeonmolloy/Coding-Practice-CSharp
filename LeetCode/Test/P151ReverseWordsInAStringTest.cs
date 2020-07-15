using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P151ReverseWordsInAStringTest {
        [TestMethod]
        public void ReverseWordsTest () {
            Assert.AreEqual("world! hello", P151ReverseWordsInAString.ReverseWords("  hello world!  "));
            Assert.AreEqual("great the will", P151ReverseWordsInAString.ReverseWords("will the   great"));
            Assert.AreEqual("friday on donuts", P151ReverseWordsInAString.ReverseWords("donuts  on    friday  "));
        }
    }
}
