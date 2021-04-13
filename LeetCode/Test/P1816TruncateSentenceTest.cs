using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P1816TruncateSentenceTest {
        [TestMethod]
        public void TruncateSentenceTest () {
            Assert.AreEqual("Hello how are you", P1816TruncateSentence.TruncateSentence("Hello how are you Will", 4));
            Assert.AreEqual("What is the solution", P1816TruncateSentence.TruncateSentence("What is the solution to this problem", 4));
            Assert.AreEqual("chopper is not a tanuki", P1816TruncateSentence.TruncateSentence("chopper is not a tanuki", 5));
        }
    }
}
