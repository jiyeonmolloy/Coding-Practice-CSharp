using LeetCode.Src.Common;

namespace LeetCode.Src {
    class P206ReverseLinkedList : ListNode{
        /// <summary>
        /// P206 Reverse Linked List. href = https://leetcode.com/problems/reverse-linked-list/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode ReverseList (ListNode head) {
            if (head == null || head.next == null) {
                return head;
            }

            ListNode current = head;
            ListNode previous = null;
            ListNode next;

            while (current != null) {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }

            return previous;
        }
    }
}
