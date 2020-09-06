using System.Collections.Generic;
using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace LeetCode.Test {
    [TestClass]
    public class P1305AllElementsInTwoBinarySearchTreesTest : TreeNode {
        [TestMethod]
        public void GetAllElementsTest () {
            IList<int> expected = new List<int>() { 0, 1, 1, 2, 3, 4 };
            expected.Should().BeEquivalentTo(P1305AllElementsInTwoBinarySearchTrees.GetAllElements(
                new TreeNode(2, new TreeNode(1), new TreeNode(4)),
                new TreeNode(1, new TreeNode(0), new TreeNode(3))));
        }
    }
}
