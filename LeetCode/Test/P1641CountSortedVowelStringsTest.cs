using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1641CountSortedVowelStringsTest {
        [TestMethod]
        public void CountVowelStringsTest () {
            Assert.AreEqual(5, P1641CountSortedVowelStrings.CountVowelStrings(1));
            Assert.AreEqual(15, P1641CountSortedVowelStrings.CountVowelStrings(2));
            Assert.AreEqual(66045, P1641CountSortedVowelStrings.CountVowelStrings(33));
        }
    }
}
