using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P461HammingDistanceTest {
        [TestMethod]
        public void HammingDistanceTest () {
            Assert.AreEqual(2, P461HammingDistance.HammingDistance(1, 4));
        }
    }
}
