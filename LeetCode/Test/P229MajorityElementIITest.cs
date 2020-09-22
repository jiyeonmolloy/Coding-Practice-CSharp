using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Test {
    [TestClass]
    public class P229MajorityElementIITest {
        [TestMethod]
        public void MajorityElementTest () {
            IList<int> expected = new List<int>() { 3 };
            Assert.IsTrue(expected.SequenceEqual(P229MajorityElementII.MajorityElement(new[] { 3, 2, 3 })));

            expected = new List<int>() { 1, 2 };
            Assert.IsTrue(expected.SequenceEqual(P229MajorityElementII.MajorityElement(new[] { 1, 1, 1, 3, 3, 2, 2, 2 })));
        }
    }
}
