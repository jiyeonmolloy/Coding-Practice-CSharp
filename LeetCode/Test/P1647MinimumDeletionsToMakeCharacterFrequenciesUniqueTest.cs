using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1647MinimumDeletionsToMakeCharacterFrequenciesUniqueTest {
        [TestMethod]
        public void MinDeletionsTest () {
            Assert.AreEqual(2, P1647MinimumDeletionsToMakeCharacterFrequenciesUnique.MinDeletions("aaabbbcc")); // 3: a, b ; 2: c
            Assert.AreEqual(0, P1647MinimumDeletionsToMakeCharacterFrequenciesUnique.MinDeletions("a"));
            Assert.AreEqual(1, P1647MinimumDeletionsToMakeCharacterFrequenciesUnique.MinDeletions("ab"));
            Assert.AreEqual(0, P1647MinimumDeletionsToMakeCharacterFrequenciesUnique.MinDeletions("aab"));
            Assert.AreEqual(2, P1647MinimumDeletionsToMakeCharacterFrequenciesUnique.MinDeletions("ceabaacb"));
        }
    }
}
