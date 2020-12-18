using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P1688CountOfMatchesInTournamentTest {
        [TestMethod]
        public void NumberOfMatchesTest () {
            Assert.AreEqual(6, P1688CountOfMatchesInTournament.NumberOfMatches(7));
            Assert.AreEqual(13, P1688CountOfMatchesInTournament.NumberOfMatches(14));
        }
    }
}
