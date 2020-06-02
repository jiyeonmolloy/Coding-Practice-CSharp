using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace LeetCode.Test {
    [TestClass]
    public class P1008ConstructBSTFromPreorderTraversalTest : TreeNode {
        [TestMethod]
        public void ConstructBstFromPreorder () {
            TreeNode treeNode = new TreeNode(8, new TreeNode(5, new TreeNode(1), new TreeNode(7)), new TreeNode(10, null, new TreeNode(12)));
            int[] preorderArray = new int[6] { 8, 5, 1, 7, 10, 12 };
            TreeNode preorderTreeNode = P1008ConstructBSTFromPreorderTraversal.BstFromPreorder(preorderArray);
            preorderTreeNode.Should().Equals(treeNode);
        }
    }
}
