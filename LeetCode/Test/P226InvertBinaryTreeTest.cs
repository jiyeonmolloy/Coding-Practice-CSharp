using FluentAssertions;
using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P226InvertBinaryTreeTest : TreeNode {
        [TestMethod]
        public void InvertBinaryTreeTest () {
            TreeNode invertedBindaryTree = P226InvertBinaryTree.InvertTree(new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9))));
            invertedBindaryTree.Should().Equals(new TreeNode(4, new TreeNode(7, new TreeNode(9), new TreeNode(6)), new TreeNode(2, new TreeNode(3), new TreeNode(1))));
        }
    }
}
