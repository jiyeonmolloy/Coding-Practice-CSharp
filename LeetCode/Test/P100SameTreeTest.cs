using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P100SameTreeTest {
        [TestMethod]
        public void IsSameTreeTest () {
            Assert.IsTrue(
                P100SameTree.IsSameTree(
                    new TreeNode(1, new TreeNode(2), new TreeNode(3)),
                    new TreeNode(1, new TreeNode(2), new TreeNode(3))));

            Assert.IsFalse(
                P100SameTree.IsSameTree(
                    new TreeNode(1, new TreeNode(2)),
                    new TreeNode(1, null, new TreeNode(3))));

            Assert.IsFalse(
                P100SameTree.IsSameTree(
                    new TreeNode(1, new TreeNode(2), new TreeNode(1)),
                    new TreeNode(1, new TreeNode(1), new TreeNode(2))));
        }
    }
}
