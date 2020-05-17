using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P206ReverseLinkedListTest : ListNode {
        [TestMethod]
        public void ReverseLinkedList () {
            ListNode head = new ListNode(5, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(1)))));
            ListNode expectedList = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

            ListNode reversedList = P206ReverseLinkedList.ReverseList(head);
            Assert.IsTrue(expectedList.AreEqual(expectedList, reversedList));
        }
    }
}
