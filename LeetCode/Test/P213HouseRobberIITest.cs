using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P213HouseRobberIITest {
        [TestMethod]
        public void RobTest () {
            Assert.AreEqual(3, P213HouseRobberII.Rob(new[] { 2, 3, 2 }));
            Assert.AreEqual(4, P213HouseRobberII.Rob(new[] { 1, 2, 3, 1 }));
        }
    }
}
