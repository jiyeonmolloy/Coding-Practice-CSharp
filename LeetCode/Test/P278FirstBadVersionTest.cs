using System;
using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P278FirstBadVersionTest {
        [TestMethod]
        public void FirstBadVersion () {
            P278FirstBadVersion p278FirstBadVersion = new P278FirstBadVersion(4);
            Assert.AreEqual(4, p278FirstBadVersion.FirstBadVersion(5));
            Assert.AreEqual(4, p278FirstBadVersion.FirstBadVersion(254));
        }
    }
}
