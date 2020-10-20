using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1626BestTeamWithNoConflictsTest {
        [TestMethod]
        public void BestTeamScoreTest () {
            Assert.AreEqual(16, P1626BestTeamWithNoConflicts.BestTeamScore(new int[] { 4, 5, 6, 5 }, new int[] { 2, 1, 2, 1 }));
            Assert.AreEqual(34, P1626BestTeamWithNoConflicts.BestTeamScore(new int[] { 1, 3, 5, 10, 15 }, new int[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(6, P1626BestTeamWithNoConflicts.BestTeamScore(new int[] { 1, 2, 3, 5 }, new int[] { 8, 9, 10, 1 }));
        }
    }
}
