using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1437CheckIfAll1sAreAtLeastKPlacesAwayTest {
        [TestMethod]
        public void All1sAreAtLeastKPlacesAway () {
            int[] test = new int[8] { 1, 0, 0, 0, 1, 0, 0, 1 };
            Assert.IsTrue(P1437CheckIfAll1sAreAtLeastKPlacesAway.KLengthApart(test, 2));

            test = new int[5] { 1, 1, 1, 1, 1 };
            Assert.IsTrue(P1437CheckIfAll1sAreAtLeastKPlacesAway.KLengthApart(test, 0));

            test = new int[4] { 0, 1, 0, 1 };
            Assert.IsTrue(P1437CheckIfAll1sAreAtLeastKPlacesAway.KLengthApart(test, 1));
        }

        [TestMethod]
        public void All1sAreNotKPlacesAway () {
            int[] test = new int[6] { 1, 0, 0, 1, 0, 1 };
            Assert.IsFalse(P1437CheckIfAll1sAreAtLeastKPlacesAway.KLengthApart(test, 2));
        }
    }
}
