using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1529BulbSwitcherIVTest {
        [TestMethod]
        public void MinFlipsTest () {
            Assert.AreEqual(3, P1529BulbSwitcherIV.MinFlips("10111"));
            Assert.AreEqual(3, P1529BulbSwitcherIV.MinFlips("101"));
            Assert.AreEqual(0, P1529BulbSwitcherIV.MinFlips("00000"));
            Assert.AreEqual(5, P1529BulbSwitcherIV.MinFlips("001011101"));
        }
    }
}
