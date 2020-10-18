using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1624LargestSubstringBetweenTwoEqualCharactersTest {
        [TestMethod]
        public void MaxLengthBetweenEqualCharactersTest () {
            Assert.AreEqual(4, P1624LargestSubstringBetweenTwoEqualCharacters.MaxLengthBetweenEqualCharacters("cabbac"));
            Assert.AreEqual(0, P1624LargestSubstringBetweenTwoEqualCharacters.MaxLengthBetweenEqualCharacters("aa"));
            Assert.AreEqual(2, P1624LargestSubstringBetweenTwoEqualCharacters.MaxLengthBetweenEqualCharacters("abca"));
            Assert.AreEqual(-1, P1624LargestSubstringBetweenTwoEqualCharacters.MaxLengthBetweenEqualCharacters("cbzxy"));
        }
    }
}
