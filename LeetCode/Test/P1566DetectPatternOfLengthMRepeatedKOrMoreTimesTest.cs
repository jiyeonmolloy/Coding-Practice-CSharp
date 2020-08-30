using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1566DetectPatternOfLengthMRepeatedKOrMoreTimesTest {
        [TestMethod]
        public void ContainsPatternTest () {
            Assert.IsTrue(P1566DetectPatternOfLengthMRepeatedKOrMoreTimes.ContainsPattern(new int[6] { 1, 2, 4, 4, 4, 4 }, 1, 3));
            Assert.IsTrue(P1566DetectPatternOfLengthMRepeatedKOrMoreTimes.ContainsPattern(new int[8] { 1, 1, 1, 3, 1, 2, 1, 2 }, 2, 2));
            Assert.IsFalse(P1566DetectPatternOfLengthMRepeatedKOrMoreTimes.ContainsPattern(new int[6] { 1, 2, 1, 2, 1, 3 }, 2, 3));
            Assert.IsFalse(P1566DetectPatternOfLengthMRepeatedKOrMoreTimes.ContainsPattern(new int[5] { 1, 2, 3, 1, 2 }, 2, 2));
            Assert.IsFalse(P1566DetectPatternOfLengthMRepeatedKOrMoreTimes.ContainsPattern(new int[4] { 2, 2, 2, 2 }, 2, 3));
            Assert.IsFalse(P1566DetectPatternOfLengthMRepeatedKOrMoreTimes.ContainsPattern(new int[4] { 2, 2, 2, 2 }, 2, 3));
            Assert.IsFalse(P1566DetectPatternOfLengthMRepeatedKOrMoreTimes.ContainsPattern(new int[26] { 3, 6, 6, 6, 5, 1, 5, 2, 2, 3, 1, 5, 2, 6, 1, 5, 1, 2, 6, 3, 3, 5, 3, 6, 3, 4 }, 6, 2));
        }
    }
}
