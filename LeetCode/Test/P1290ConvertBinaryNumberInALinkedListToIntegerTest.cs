using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1290ConvertBinaryNumberInALinkedListToIntegerTest : ListNode {
        [TestMethod]
        public void ClimbingChairsTest () {
            Assert.AreEqual(5, P1290ConvertBinaryNumberInALinkedListToInteger.GetDecimalValue(new ListNode(1, new ListNode(0, new ListNode(1)))));
            Assert.AreEqual(0, P1290ConvertBinaryNumberInALinkedListToInteger.GetDecimalValue(new ListNode(0, new ListNode(0))));
        }
    }
}
