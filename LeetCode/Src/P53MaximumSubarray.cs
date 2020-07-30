using System;

namespace LeetCode.Src {
    /// <summary>
    /// P53 Maximum Subarray
    ///  key: Kadane's Algorithm
    ///  href = https://leetcode.com/problems/maximum-subarray/
    /// </summary>
    class P53MaximumSubarray {
        public static int MaxSubArray (int[] nums) {
            int maxCurrent = nums[0];
            int maxGlobal = maxCurrent;

            int current;
            for (int i = 1; i < nums.Length; i++) {
                current = nums[i];
                maxCurrent = Math.Max(maxCurrent + current, current);
                maxGlobal = Math.Max(maxCurrent, maxGlobal);
            }

            return maxGlobal;
        }
    }
}
