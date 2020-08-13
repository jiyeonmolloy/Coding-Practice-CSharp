using System.Collections.Generic;
using System.Linq;
using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P119PascalsTriangleIITest {
        [TestMethod]
        public void GetRowTest () {
            IList<int> expectedRow = new List<int>() { 1, 3, 3, 1 };
            Assert.IsTrue(expectedRow.SequenceEqual(P119PascalsTriangleII.GetRow(3)));

            expectedRow = new List<int>() { 1 };
            Assert.IsTrue(expectedRow.SequenceEqual(P119PascalsTriangleII.GetRow(0)));
        }
    }
}
