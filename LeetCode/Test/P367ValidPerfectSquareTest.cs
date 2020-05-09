using System;
using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P367ValidPerfectSquareTest {
        [TestMethod]
        public void IsPerfectSquare () {
            Assert.IsTrue(P367ValidPerfectSquare.IsPerfectSquare(16));
        }

        [TestMethod]
        public void IsNotPerfectSquare () {
            Assert.IsFalse(P367ValidPerfectSquare.IsPerfectSquare(14));
        }
    }
}
