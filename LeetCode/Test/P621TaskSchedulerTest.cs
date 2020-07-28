using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P621TaskSchedulerTest {
        [TestMethod]
        public void LeastIntervalTest () {
            Assert.AreEqual(8, P621TaskScheduler.LeastInterval(new char[6] { 'A', 'A', 'A', 'B', 'B', 'B' }, 2));
            Assert.AreEqual(6, P621TaskScheduler.LeastInterval(new char[6] { 'A', 'A', 'A', 'B', 'B', 'B' }, 0));
            Assert.AreEqual(16, P621TaskScheduler.LeastInterval(new char[12] { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'C', 'D', 'E', 'F', 'G' }, 2));
        }
    }
}
