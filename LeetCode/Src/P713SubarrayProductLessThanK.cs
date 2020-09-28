
namespace LeetCode.Src {
    /// <summary>
    /// P713 Subarray Product Less Than K
    ///  href = https://leetcode.com/problems/subarray-product-less-than-k/submissions/
    ///  Key: Sliding window
    /// </summary>
    class P713SubarrayProductLessThanK {
        public static int NumSubarrayProductLessThanK (int[] nums, int k) {
            int left = 0;
            int product = 1;
            int count = 0;

            for (int right = 0; right < nums.Length; right++) {
                product *= nums[right];

                while (product >= k && left <= right) {
                    product /= nums[left];
                    left++;
                }

                count += right - left + 1;
            }

            return count;
        }
    }
}
