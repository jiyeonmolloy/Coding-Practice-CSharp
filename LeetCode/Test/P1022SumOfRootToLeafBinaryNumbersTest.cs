using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1022SumOfRootToLeafBinaryNumbersTest {
        [TestMethod]
        public void SumRootToLeafTest () {
            Assert.AreEqual(22, P1022SumOfRootToLeafBinaryNumbers.SumRootToLeaf(new TreeNode(1,
                new TreeNode(0, new TreeNode(0), new TreeNode(1)),
                new TreeNode(1, new TreeNode(0), new TreeNode(1)))));
        }
    }
}
