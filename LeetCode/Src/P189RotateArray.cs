
namespace LeetCode.Src {
    /// <summary>
    /// P189 Rotate Array
    ///  href = https://leetcode.com/problems/rotate-array/
    /// </summary>
    class P189RotateArray {
        public static int[] Rotate (int[] nums, int k) {
            k %= nums.Length;

            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);

            return nums;
        }

        private static void Reverse (int[] nums, int start, int end) {
            int temp;
            while (start < end) {
                temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
