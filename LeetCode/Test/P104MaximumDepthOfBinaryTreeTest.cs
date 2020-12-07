using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;
using LeetCode.Src.Common;

namespace LeetCode.Test {
    [TestClass]
    public class P104MaximumDepthOfBinaryTreeTest {
        [TestMethod]
        public void MaxDepthTest () {
            Assert.AreEqual(3, P104MaximumDepthOfBinaryTree.MaxDepth(new TreeNode(3,
                new TreeNode(9),
                new TreeNode(20, new TreeNode(15), new TreeNode(7)))));
            Assert.AreEqual(2, P111MinimumDepthOfBinaryTree.MinDepth(new TreeNode(1,
                null,
                new TreeNode(2))));
        }
    }
}
