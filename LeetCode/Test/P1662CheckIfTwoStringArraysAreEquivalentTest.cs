using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1662CheckIfTwoStringArraysAreEquivalentTest {
        [TestMethod]
        public void ArrayStringsAreEqualTest () {
            Assert.IsTrue(P1662CheckIfTwoStringArraysAreEquivalent.ArrayStringsAreEqual(new string[] { "ab", "c" }, new string[] { "a", "bc" }));
            Assert.IsFalse(P1662CheckIfTwoStringArraysAreEquivalent.ArrayStringsAreEqual(new string[] { "a", "cb" }, new string[] { "a", "bc" }));
        }
    }
}
