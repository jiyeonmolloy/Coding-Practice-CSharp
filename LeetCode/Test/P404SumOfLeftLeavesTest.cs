using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P404SumOfLeftLeavesTest {
        [TestMethod]
        public void SumOfLeftLeavesTest () {
            Assert.AreEqual(24, P404SumOfLeftLeaves.SumOfLeftLeaves(new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(20, new TreeNode(15))))));
        }
    }
}
