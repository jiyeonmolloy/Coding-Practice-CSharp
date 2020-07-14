using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1344AngleBetweenHandsOfAClockTest {
        [TestMethod]
        public void AngleClockTest () {
            Assert.AreEqual(165, P1344AngleBetweenHandsOfAClock.AngleClock(12, 30));
            Assert.AreEqual(75, P1344AngleBetweenHandsOfAClock.AngleClock(3, 30));
            Assert.AreEqual(7.5, P1344AngleBetweenHandsOfAClock.AngleClock(3, 15));
            Assert.AreEqual(155, P1344AngleBetweenHandsOfAClock.AngleClock(4, 50));
            Assert.AreEqual(0, P1344AngleBetweenHandsOfAClock.AngleClock(12, 0));
            Assert.AreEqual(76.50000, P1344AngleBetweenHandsOfAClock.AngleClock(1, 57));
        }
    }
}
