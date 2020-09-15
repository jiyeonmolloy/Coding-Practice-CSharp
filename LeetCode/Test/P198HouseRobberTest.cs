using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P198HouseRobberTest {
        [TestMethod]
        public void RobTest () {
            Assert.AreEqual(4, P198HouseRobber.Rob(new[] { 1, 2, 3, 1 }));
            Assert.AreEqual(12, P198HouseRobber.Rob(new[] { 2, 7, 9, 3, 1 }));
        }
    }
}
