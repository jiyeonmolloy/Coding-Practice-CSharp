using System;

namespace LeetCode.Src {
    /// <summary>
    /// P456 132 Pattern
    ///  href = https://leetcode.com/problems/132-pattern/
    /// </summary>
    class P456OneThreeTwoPattern {
        public static bool Find132pattern (int[] nums) {
            int n = nums.Length;
            int min = nums[0];

            for (int j = 1; j < n - 1; j++) {
                for (int k = j + 1; k < n; k++) {
                    if (min < nums[k] && nums[k] < nums[j]) {
                        return true;
                    }
                }

                min = Math.Min(nums[j], min);
            }
            return false;
        }
    }
}
