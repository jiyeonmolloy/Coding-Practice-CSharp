using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P129SumRootToLeafNumbersTest {
        [TestMethod]
        public void SumNumbersTest () {
            Assert.AreEqual(25, P129SumRootToLeafNumbers.SumNumbers(new TreeNode(1, new TreeNode(2), new TreeNode(3))));
            Assert.AreEqual(1026, P129SumRootToLeafNumbers.SumNumbers(new TreeNode(4, new TreeNode(9, new TreeNode(5), new TreeNode(1)), new TreeNode(0))));
        }
    }
}
