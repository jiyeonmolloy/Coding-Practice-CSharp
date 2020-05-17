
namespace LeetCode.Src.Common {
    public class ListNode {
        public int val;
        public ListNode next;

        public ListNode (int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }

        public bool AreEqual (ListNode inputNode, ListNode targetNode) {
            while (inputNode != null) {
                if (inputNode.val != targetNode.val) {
                    return false;
                }
                inputNode = inputNode.next;
                targetNode = targetNode.next;
            }

            return true;
        }
    }
}
