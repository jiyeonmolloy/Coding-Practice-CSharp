using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P933NumberOfRecentCallsTest {
        [TestMethod]
        public void PingTest () {
            P933NumberOfRecentCalls recentCounter = new P933NumberOfRecentCalls();
            Assert.AreEqual(1, recentCounter.Ping(1));
            Assert.AreEqual(2, recentCounter.Ping(100));
            Assert.AreEqual(3, recentCounter.Ping(3001));
            Assert.AreEqual(3, recentCounter.Ping(3002));

            recentCounter = new P933NumberOfRecentCalls();
            Assert.AreEqual(1, recentCounter.Ping(642));
            Assert.AreEqual(2, recentCounter.Ping(1849));
            Assert.AreEqual(1, recentCounter.Ping(4921));
        }
    }
}
