using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1513NumberOfSubstringsWithOnly1sTest {
        [TestMethod]
        public void NumSubTest () {
            Assert.AreEqual(21, P1513NumberOfSubstringsWithOnly1s.NumSub("111111"));
            Assert.AreEqual(9, P1513NumberOfSubstringsWithOnly1s.NumSub("0110111"));
            Assert.AreEqual(2, P1513NumberOfSubstringsWithOnly1s.NumSub("101"));
            Assert.AreEqual(0, P1513NumberOfSubstringsWithOnly1s.NumSub("000"));
            Assert.AreEqual(62, P1513NumberOfSubstringsWithOnly1s.NumSub("1111111111011010011"));
        }
    }
}
