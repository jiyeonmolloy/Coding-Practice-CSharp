using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1455CheckIfAWordOccursAsAPrefixOfAnyWordInASentenceTest {
        [TestMethod]
        public void CheckIfAWordOccursAsAPrefixOfAnyWordInASentence () {
            Assert.AreEqual(4, P1455CheckIfAWordOccursAsAPrefixOfAnyWordInASentence.IsPrefixOfWord("i love eating cakeee", "cake"));
        }
    }
}
