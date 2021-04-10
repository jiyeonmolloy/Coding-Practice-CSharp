using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P1704DetermineIfStringHalvesAreAlikeTest {
        [TestMethod]
        public void HalvesAreAlikeTest () {
            Assert.IsTrue(P1704DetermineIfStringHalvesAreAlike.HalvesAreAlike("book"));
            Assert.IsFalse(P1704DetermineIfStringHalvesAreAlike.HalvesAreAlike("textbook"));
            Assert.IsFalse(P1704DetermineIfStringHalvesAreAlike.HalvesAreAlike("MerryChristmas"));
            Assert.IsTrue(P1704DetermineIfStringHalvesAreAlike.HalvesAreAlike("AbCdEfGh"));
        }
    }
}
