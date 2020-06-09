using System;
using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace LeetCode.Test {
    [TestClass]
    public class P1143LongestCommonSubsequenceTest {
        [TestMethod]
        public void LongestCommonSubsequenceTest () {
            Assert.AreEqual(3, P1143LongestCommonSubsequence.LongestCommonSubsequence("abcde", "ace"));
            Assert.AreEqual(3, P1143LongestCommonSubsequence.LongestCommonSubsequence("abc", "abc"));
            Assert.AreEqual(0, P1143LongestCommonSubsequence.LongestCommonSubsequence("abc", "def"));
        }
    }
}
