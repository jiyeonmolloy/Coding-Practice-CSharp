using LeetCode.Src.Common;

namespace LeetCode.Src {
    /// <summary>
    /// P147 Insertion Sort List
    ///  href = https://leetcode.com/problems/insertion-sort-list/
    /// </summary>
    class P147InsertionSortList : ListNode{
        public static ListNode InsertionSortList (ListNode head) {
            ListNode sorted = new ListNode();
            ListNode current = head;
            ListNode previous;
            ListNode next;
            ListNode nextRound;

            while (current != null) {
                previous = sorted;
                next = sorted.next;

                while (next != null) {
                    if (current.val < next.val) {
                        break;
                    }
                    previous = next;
                    next = next.next;
                }

                nextRound = current.next;
                current.next = next;
                previous.next = current;
                current = nextRound;
            }

            return sorted.next;
        }
    }
}
