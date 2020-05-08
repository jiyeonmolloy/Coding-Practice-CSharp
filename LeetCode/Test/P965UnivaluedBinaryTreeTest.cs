using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P965UnivaluedBinaryTreeTest : TreeNode {
        [TestMethod]
        public void IsUnivaluedBinaryTree () {
            TreeNode treeNode = new TreeNode(1, new TreeNode(1, new TreeNode(1, new TreeNode(1))), new TreeNode(1, new TreeNode(1)));
            Assert.IsTrue(P965UnivaluedBinaryTree.IsUnivalTree(treeNode));
        }

        [TestMethod]
        public void IsNotUnivaluedBinaryTree () {
            TreeNode treeNode = new TreeNode(1, new TreeNode(1, new TreeNode(1, new TreeNode(1))), new TreeNode(1, new TreeNode(2)));
            Assert.IsFalse(P965UnivaluedBinaryTree.IsUnivalTree(treeNode));
        }
    }
}
