
namespace LeetCode.Src {
    /// <summary>
    /// P287 Find the duplicate number
    ///  href = https://leetcode.com/problems/find-the-duplicate-number/
    /// </summary>
    class P287FindTheDuplicateNumber {
        public static int FindDuplicate (int[] nums) {
            int fast = nums[0];
            int slow = fast;

            do {
                // Perform cycle detection 
                slow = nums[slow];
                fast = nums[nums[fast]];
            } while (fast != slow);

            // Find entry point
            int node = nums[0];
            while (node != slow) {
                slow = nums[slow];
                node = nums[node];
            }

            return node;
        }
    }
}
