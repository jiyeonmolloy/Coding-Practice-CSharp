using System;
using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1544MakeTheStringGreatTest {
        [TestMethod]
        public void MakeGoodTest () {
            Assert.AreEqual(String.Empty, P1544MakeTheStringGreat.MakeGood("eeAaEE"));
            Assert.AreEqual("leetcode", P1544MakeTheStringGreat.MakeGood("leEeetcode"));
            Assert.AreEqual(String.Empty, P1544MakeTheStringGreat.MakeGood("abBAcC"));
            Assert.AreEqual("s", P1544MakeTheStringGreat.MakeGood("s"));
        }
    }
}
