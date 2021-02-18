using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P1437CheckIfAllOnesAreAtLeastLengthKPlacesAwayTest {
        [TestMethod]
        public void KLengthApartTest () {
            Assert.IsTrue(P1437CheckIfAllOnesAreAtLeastLengthKPlacesAway.KLengthApart(new[] { 1, 0, 0, 0, 1, 0, 0, 1 }, 2));
            Assert.IsFalse(P1437CheckIfAllOnesAreAtLeastLengthKPlacesAway.KLengthApart(new[] { 1, 0, 0, 1, 0, 1 }, 2));
        }
    }
}
