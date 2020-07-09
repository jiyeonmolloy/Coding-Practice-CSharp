using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P662MaximumWidthOfBinaryTreeTest {
        [TestMethod]
        public void WidthOfBinaryTreeTest () {
            TreeNode treeNode = new TreeNode(1, new TreeNode(3, new TreeNode(5), new TreeNode(3)), new TreeNode(2, null, new TreeNode(9)));
            P662MaximumWidthOfBinaryTree.WidthOfBinaryTree(treeNode);

            treeNode = new TreeNode(2, new TreeNode(3, new TreeNode(5), new TreeNode(3)));
            P662MaximumWidthOfBinaryTree.WidthOfBinaryTree(treeNode);

            treeNode = new TreeNode(2, new TreeNode(1, new TreeNode(3, new TreeNode(5)), new TreeNode(2)), null);
            P662MaximumWidthOfBinaryTree.WidthOfBinaryTree(treeNode);
        }
    }
}
