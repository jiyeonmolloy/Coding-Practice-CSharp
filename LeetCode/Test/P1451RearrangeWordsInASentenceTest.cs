using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1451RearrangeWordsInASentenceTest {
        [TestMethod]
        public void RearrangeWordsInASentence () {
            string text = "Leetcode is cool";
            Assert.AreEqual("Is cool leetcode", P1451RearrangeWordsInASentence.ArrangeWords(text));

            text = "Keep calm and code on";
            Assert.AreEqual("On and keep calm code", P1451RearrangeWordsInASentence.ArrangeWords(text));

            text = "To be or not to be";
            Assert.AreEqual("To be or to be not", P1451RearrangeWordsInASentence.ArrangeWords(text));
        }
    }
}
