using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P771JewelsAndStonesTest {
        [TestMethod]
        public void NumberOfJewels () {
            Assert.AreEqual(3, P771JewelsAndStones.NumJewelsInStones("aA", "aAAbbbb"));
            Assert.AreEqual(0, P771JewelsAndStones.NumJewelsInStones("z", "ZZ"));
        }
    }
}
