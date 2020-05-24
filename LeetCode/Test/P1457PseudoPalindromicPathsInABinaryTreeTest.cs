using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1457PseudoPalindromicPathsInABinaryTreeTest : TreeNode {
        [TestMethod]
        public void PseudoPalindromePathExists () {
            TreeNode treeNode = new TreeNode(2, new TreeNode(3, new TreeNode(3), new TreeNode(1)), new TreeNode(1, null, new TreeNode(1)));
            Assert.AreEqual(2, P1457PseudoPalindromicPathsInABinaryTree.PseudoPalindromicPaths(treeNode));
        }

        [TestMethod]
        public void PseudoPalindromePathDoesNotExist () {
            TreeNode treeNode = new TreeNode(9);
            Assert.AreEqual(1, P1457PseudoPalindromicPathsInABinaryTree.PseudoPalindromicPaths(treeNode));

            treeNode = new TreeNode(2, new TreeNode(1, new TreeNode(1), new TreeNode(3, null, new TreeNode(1))), new TreeNode(1));
            Assert.AreEqual(1, P1457PseudoPalindromicPathsInABinaryTree.PseudoPalindromicPaths(treeNode));
        }
    }
}
