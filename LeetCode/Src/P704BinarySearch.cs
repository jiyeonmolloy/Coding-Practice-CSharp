
namespace LeetCode.Src {
    /// <summary>
    /// P704 Binary Search
    ///  href = https://leetcode.com/problems/binary-search/
    /// </summary>
    class P704BinarySearch {
        public static int Search (int[] nums, int target) {
            int left = 0;
            int right = nums.Length - 1;
            int mid;

            while (left <= right) {
                mid = left + ((right - left) / 2);

                if (nums[mid] == target) {
                    return mid;
                }

                if (nums[mid] > target) {
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}
