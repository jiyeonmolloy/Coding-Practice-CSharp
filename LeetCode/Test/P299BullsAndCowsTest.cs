using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P299BullsAndCowsTest {
        [TestMethod]
        public void GetHintTest () {
            Assert.AreEqual("1A3B", P299BullsAndCows.GetHint("1807", "7810"));
            Assert.AreEqual("1A1B", P299BullsAndCows.GetHint("1123", "0111"));
        }
    }
}
