using System;
using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P476NumberComplementTest {
        [TestMethod]
        public void FindBinaryComplement () {
            Assert.AreEqual(2, P476NumberComplement.FindComplement(5));
            Assert.AreEqual(0, P476NumberComplement.FindComplement(1));
            Assert.AreEqual(Int32.MaxValue, P476NumberComplement.FindComplement(0));
        }
    }
}
