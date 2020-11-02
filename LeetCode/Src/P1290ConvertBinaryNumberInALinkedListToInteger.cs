using LeetCode.Src.Common;

namespace LeetCode.Src {
    /// <summary>
    /// P1290 Convert Binary Number In A Linked List To Integer
    ///  href = https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
    /// </summary>
    class P1290ConvertBinaryNumberInALinkedListToInteger : ListNode{
        public static int GetDecimalValue (ListNode head) {
            int output = 0;
            while (head != null) {
                output = output << 1 | head.val;
                head = head.next;
            }

            return output;
        }
    }
}
