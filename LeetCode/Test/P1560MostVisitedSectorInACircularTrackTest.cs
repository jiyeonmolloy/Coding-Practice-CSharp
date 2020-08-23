using System.Collections.Generic;
using System.Linq;
using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1560MostVisitedSectorInACircularTrackTest {
        [TestMethod]
        public void MostVisitedTest () {
            IList<int> expected = new List<int> { 1, 2 };
            Assert.IsTrue(expected.SequenceEqual(P1560MostVisitedSectorInACircularTrack.MostVisited(4, new int[4] { 1, 3, 1, 2 })));

            expected = new List<int> { 2 };
            Assert.IsTrue(expected.SequenceEqual(P1560MostVisitedSectorInACircularTrack.MostVisited(2, new int[9] { 2, 1, 2, 1, 2, 1, 2, 1, 2 })));

            expected = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            Assert.IsTrue(expected.SequenceEqual(P1560MostVisitedSectorInACircularTrack.MostVisited(7, new int[4] { 1, 3, 5, 7 })));

            expected = new List<int> { 1, 3 };
            Assert.IsTrue(expected.SequenceEqual(P1560MostVisitedSectorInACircularTrack.MostVisited(3, new int[14] { 3, 2, 1, 2, 1, 3, 2, 1, 2, 1, 3, 2, 3, 1 })));
        }
    }
}
