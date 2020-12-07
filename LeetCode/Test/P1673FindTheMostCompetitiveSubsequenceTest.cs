using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1673FindTheMostCompetitiveSubsequenceTest {
        [TestMethod]
        public void MostCompetitiveTest () {
            CollectionAssert.AreEqual(new int[] { 2, 3, 3, 4 }, P1673FindTheMostCompetitiveSubsequence.MostCompetitive(new int[] { 2, 4, 3, 3, 5, 4, 9, 6 }, 4));
            CollectionAssert.AreEqual(new int[] { 2, 6 }, P1673FindTheMostCompetitiveSubsequence.MostCompetitive(new int[] { 3, 5, 2, 6 }, 2));
            CollectionAssert.AreEqual(new int[] { 0, 42, 15 }, P1673FindTheMostCompetitiveSubsequence.MostCompetitive(new int[] { 65, 35, 89, 39, 25, 0, 42, 87, 15 }, 3));
        }
    }
}
