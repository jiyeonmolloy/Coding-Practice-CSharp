using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P938RangeSumOfBSTTest {
        [TestMethod]
        public void RangeSumBSTTest () {
            P938RangeSumOfBST rangeSum = new P938RangeSumOfBST();
            Assert.AreEqual(32, rangeSum.RangeSumBSTDfs(new TreeNode(10,
                new TreeNode(5, new TreeNode(3), new TreeNode(7)),
                new TreeNode(15, null, new TreeNode(18))), 7, 15));

            Assert.AreEqual(32, rangeSum.RangeSumBSTIterative(new TreeNode(10,
                new TreeNode(5, new TreeNode(3), new TreeNode(7)),
                new TreeNode(15, null, new TreeNode(18))), 7, 15));
        }
    }
}
