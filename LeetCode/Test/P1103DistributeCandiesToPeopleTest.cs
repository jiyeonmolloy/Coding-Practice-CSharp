using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1103DistributeCandiesToPeopleTest {
        [TestMethod]
        public void DistributeCandiesTest () {
            CollectionAssert.AreEqual(new int[4] { 1, 2, 3, 1 }, P1103DistributeCandiesToPeople.DistributeCandies(7, 4));
            CollectionAssert.AreEqual(new int[3] { 5, 2, 3 }, P1103DistributeCandiesToPeople.DistributeCandies(10, 3));
            CollectionAssert.AreEqual(new int[4] { 15, 18, 15, 12 }, P1103DistributeCandiesToPeople.DistributeCandies(60, 4));
        }
    }
}
