using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace LeetCode.Test {
    [TestClass]
    public class P450DeleteNodeInABSTTest : TreeNode {
        [TestMethod]
        public void DeleteNodeTest () {
            TreeNode BST = P450DeleteNodeInABST.DeleteNode(new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(6, right = new TreeNode(7))), 3);
            BST.Should().Equals(new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(6, right = new TreeNode(7))));

            BST = P450DeleteNodeInABST.DeleteNode(new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(6, right = new TreeNode(7))), 6);
            BST.Should().Equals(new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(7)));
        }
    }
}
