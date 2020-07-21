using LeetCode.Src.Common;

namespace LeetCode.Src {
    /// <summary>
    /// P203 Remove Linked List Elements
    ///  href = https://leetcode.com/problems/remove-linked-list-elements/
    /// </summary>
    class P203RemoveLinkedListElements : ListNode {
        public static ListNode RemoveElements (ListNode head, int val) {
            if (head == null) {
                return null;
            }

            ListNode current = head;
            ListNode next;

            while (current != null) {
                if (current.val == val) {
                    head = head.next;
                    current = head;

                } else if (current.next?.val == val) {
                    next = current.next;
                    current.next = next.next;
                    next.next = null;

                } else {
                    current = current.next;
                }
            }

            return head;
        }
    }
}
