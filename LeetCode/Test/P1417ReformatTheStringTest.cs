using System;
using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1417ReformatTheStringTest {
        [TestMethod]
        public void CanPermutateAlphanumericString () {
            P1417ReformatTheString permutateString = new P1417ReformatTheString();
            Assert.AreEqual("a0b1c2", permutateString.Permutate("a0b1c2"));
            Assert.AreEqual("c2o0v2i0d", permutateString.Permutate("covid2020"));
        }

        [TestMethod]
        public void CannotPermutateAlphaString() {
            Assert.AreEqual(String.Empty, new P1417ReformatTheString().Permutate("leetcode"));
        }

        [TestMethod]
        public void CannotPermuateNumericString() {
            Assert.AreEqual(String.Empty, new P1417ReformatTheString().Permutate("1229857369"));
        }
    }
}
