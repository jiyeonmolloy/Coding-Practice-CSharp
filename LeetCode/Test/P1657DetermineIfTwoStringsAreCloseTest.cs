using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1657DetermineIfTwoStringsAreCloseTest {
        [TestMethod]
        public void CloseStringsTest () {
            Assert.IsTrue(P1657DetermineIfTwoStringsAreClose.CloseStrings("abc", "bca"));
            Assert.IsFalse(P1657DetermineIfTwoStringsAreClose.CloseStrings("a", "aa"));
            Assert.IsTrue(P1657DetermineIfTwoStringsAreClose.CloseStrings("cabbba", "abbccc"));
            Assert.IsFalse(P1657DetermineIfTwoStringsAreClose.CloseStrings("cabbba", "aabbss"));
        }
    }
}
