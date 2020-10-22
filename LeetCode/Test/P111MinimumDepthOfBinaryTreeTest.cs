using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P111MinimumDepthOfBinaryTreeTest {
        [TestMethod]
        public void SumRootToLeafTest () {
            Assert.AreEqual(2, P111MinimumDepthOfBinaryTree.MinDepth(new TreeNode(3,
                new TreeNode(9),
                new TreeNode(20, new TreeNode(15), new TreeNode(7)))));
            Assert.AreEqual(5, P111MinimumDepthOfBinaryTree.MinDepth(new TreeNode(2,
                null,
                new TreeNode(3,
                    null,
                    new TreeNode(4,
                        null,
                        new TreeNode(5,
                            null,
                            new TreeNode(6)))))));
        }
    }
}
