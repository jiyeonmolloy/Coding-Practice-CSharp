using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P700SearchInABinarySearchTreeTest {
        [TestMethod]
        public void SearchBSTTest () {
            TreeNode BST = P700SearchInABinarySearchTree.SearchBST(new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7)), 2);
            BST.Should().Equals(new TreeNode(2, new TreeNode(1), new TreeNode(3)));
            BST = P700SearchInABinarySearchTree.SearchBST(new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9))), 2);
            BST.Should().Equals(null);
        }
    }
}
