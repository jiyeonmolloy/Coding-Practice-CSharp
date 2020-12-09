using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P1010PairsOfSongsWithTotalDurationsDivisibleBy60Test {
        [TestMethod]
        public void NumPairsDivisibleBy60Test () {
            Assert.AreEqual(3, P1010PairsOfSongsWithTotalDurationsDivisibleBy60.NumPairsDivisibleBy60(new[] { 30, 20, 150, 100, 40 }));
            Assert.AreEqual(3, P1010PairsOfSongsWithTotalDurationsDivisibleBy60.NumPairsDivisibleBy60(new[] { 60, 60, 60 }));
        }
    }
}
