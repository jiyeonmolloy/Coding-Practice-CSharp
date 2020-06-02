using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P525ContiguousArrayTest {
        [TestMethod]
        public void FindMaxLengthOfContiguousArray () {
            Assert.AreEqual(2, P525ContiguousArray.FindMaxLength(new int[2] { 0, 1 }));
            Assert.AreEqual(2, P525ContiguousArray.FindMaxLength(new int[3] { 0, 1, 0 }));
            Assert.AreEqual(4, P525ContiguousArray.FindMaxLength(new int[4] { 0, 1, 0, 1 }));
            Assert.AreEqual(2, P525ContiguousArray.FindMaxLength(new int[6] { 0, 1, 1, 1, 0, 1 }));
        }
    }
}
