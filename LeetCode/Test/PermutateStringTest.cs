using System;
using CodingPractice.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPractice.Test {
    [TestClass]
    public class PermutateStringTest {
        [TestMethod]
        public void CanPermutateAlphanumericString () {
            PermutateString permutateString = new PermutateString();
            Assert.AreEqual("a0b1c2", permutateString.Permutate("a0b1c2"));
            Assert.AreEqual("c2o0v2i0d", permutateString.Permutate("covid2020"));
        }

        [TestMethod]
        public void CannotPermutateAlphaString() {
            Assert.AreEqual(String.Empty, new PermutateString().Permutate("leetcode"));
        }

        [TestMethod]
        public void CannotPermuateNumericString() {
            PermutateString permutateString = new PermutateString();
            Assert.AreEqual(String.Empty, new PermutateString().Permutate("1229857369"));
        }
    }
}
