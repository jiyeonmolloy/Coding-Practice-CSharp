using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Test {
    [TestClass]
    public class P310MinimumHeightTreesTest {
        [TestMethod]
        public void FindMinHeightTreesTest () {
            IList<int> roots = new List<int>() { 1 };
            Assert.IsTrue(roots.SequenceEqual(P310MinimumHeightTrees.FindMinHeightTrees(4, new[] { new[] { 1, 0 }, new[] { 1, 2 }, new[] { 1, 3 } })));

            roots = new List<int>() { 3, 4 };
            Assert.IsTrue(roots.SequenceEqual(P310MinimumHeightTrees.FindMinHeightTrees(6, new[] { new[] { 3, 0 }, new[] { 3, 1 }, new[] { 3, 2 }, new[] { 3, 4 }, new[] { 5, 4 } })));

            roots = new List<int>() { 0 };
            Assert.IsTrue(roots.SequenceEqual(P310MinimumHeightTrees.FindMinHeightTrees(1, new int[][] { })));

            roots = new List<int>() { 0, 1 };
            Assert.IsTrue(roots.SequenceEqual(P310MinimumHeightTrees.FindMinHeightTrees(2, new[] { new[] { 0, 1 } })));
        }
    }
}
