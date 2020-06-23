using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P222CountCompleteTreeNodesTest : TreeNode {
        [TestMethod]
        public void CountNodesTest () {
            Assert.AreEqual(6, P222CountCompleteTreeNodes.CountNodes(
                new TreeNode(1,
                    new TreeNode(2,
                        new TreeNode(4), new TreeNode(5)),
                    new TreeNode(3,
                        new TreeNode(6)))));
        }
    }
}
