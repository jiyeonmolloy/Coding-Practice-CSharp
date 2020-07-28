using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1528ShuffleStringTest {
        [TestMethod]
        public void RestoreStringTest () {
            Assert.AreEqual("leetcode", P1528ShuffleString.RestoreString("codeleet", new int[8] { 4, 5, 6, 7, 0, 2, 1, 3 }));
            Assert.AreEqual("abc", P1528ShuffleString.RestoreString("abc", new int[3] { 0, 1, 2 }));
            Assert.AreEqual("aigoo", P1528ShuffleString.RestoreString("oioga", new int[5] { 3, 1, 4, 2, 0 }));
        }
    }
}
