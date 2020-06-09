using System;
using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P392IsSubsequenceTest {
        [TestMethod]
        public void IsSubsequenceTest () {
            Assert.IsTrue(P392IsSubsequence.IsSubsequence("abc", "ahbgdc"));
            Assert.IsFalse(P392IsSubsequence.IsSubsequence("axc", "ahbgdc"));
            Assert.IsTrue(P392IsSubsequence.IsSubsequence(String.Empty, "ahbgdc"));
        }
    }
}
