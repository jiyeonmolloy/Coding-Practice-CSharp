using LeetCode.Src;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P203RemoveLinkedListElementsTest {
        [TestMethod]
        public void RemoveElementsTest () {
            ListNode input = new ListNode(1, new ListNode(2, new ListNode(6, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6)))))));
            ListNode expectedList = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

            ListNode actualList = P203RemoveLinkedListElements.RemoveElements(input, 6);
            Assert.IsTrue(expectedList.AreEqual(expectedList, actualList));
        }
    }
}
