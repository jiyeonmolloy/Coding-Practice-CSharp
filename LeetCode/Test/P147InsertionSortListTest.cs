using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P147InsertionSortListTest {
        [TestMethod]
        public void InsertionSortListTest () {
            ListNode expectedList = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            Assert.IsTrue(expectedList.AreEqual(expectedList, P147InsertionSortList.InsertionSortList(new ListNode(4, new ListNode(2, new ListNode(1, new ListNode(3)))))));

            expectedList = new ListNode(-1, new ListNode(0, new ListNode(3, new ListNode(4, new ListNode(5)))));
            Assert.IsTrue(expectedList.AreEqual(expectedList, P147InsertionSortList.InsertionSortList(new ListNode(-1, new ListNode(0, new ListNode(3, new ListNode(4, new ListNode(5))))))));
        }
    }
}
