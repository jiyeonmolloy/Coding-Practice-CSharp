using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1784CheckIfBinaryStringHasAtMostOneSegmentOfOnesTest {
        [TestMethod]
        public void CheckOnesSegmentTest () {
            Assert.IsTrue(P1784CheckIfBinaryStringHasAtMostOneSegmentOfOnes.CheckOnesSegment("11"));
            Assert.IsFalse(P1784CheckIfBinaryStringHasAtMostOneSegmentOfOnes.CheckOnesSegment("1001"));
            Assert.IsTrue(P1784CheckIfBinaryStringHasAtMostOneSegmentOfOnes.CheckOnesSegment("110"));
            Assert.IsTrue(P1784CheckIfBinaryStringHasAtMostOneSegmentOfOnes.CheckOnesSegment("1"));
            Assert.IsTrue(P1784CheckIfBinaryStringHasAtMostOneSegmentOfOnes.CheckOnesSegment("10"));
            Assert.IsFalse(P1784CheckIfBinaryStringHasAtMostOneSegmentOfOnes.CheckOnesSegment("1100111"));
        }
    }
}
