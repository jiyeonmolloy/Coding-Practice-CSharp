using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1446ConsecutiveCharactersTest {
        [TestMethod]
        public void MaxPowerTest () {
            Assert.AreEqual(2, P1446ConsecutiveCharacters.MaxPower("leetcode"));
            Assert.AreEqual(5, P1446ConsecutiveCharacters.MaxPower("abbcccddddeeeeedcba"));
            Assert.AreEqual(5, P1446ConsecutiveCharacters.MaxPower("triplepillooooow"));
            Assert.AreEqual(11, P1446ConsecutiveCharacters.MaxPower("hooraaaaaaaaaaay"));
            Assert.AreEqual(3, P1446ConsecutiveCharacters.MaxPower("tooobbyyy"));
        }
    }
}
