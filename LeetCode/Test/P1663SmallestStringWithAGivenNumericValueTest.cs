using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1663SmallestStringWithAGivenNumericValueTest {
        [TestMethod]
        public void GetSmallestStringTest () {
            Assert.AreEqual("aay", P1663SmallestStringWithAGivenNumericValue.GetSmallestString(3, 27));
            Assert.AreEqual("aaszz", P1663SmallestStringWithAGivenNumericValue.GetSmallestString(5, 73));
            Assert.AreEqual("aaaszz", P1663SmallestStringWithAGivenNumericValue.GetSmallestString(6, 74));
        }
    }
}
