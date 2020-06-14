using System;

namespace LeetCode.Src {
    /// <summary>
    /// P5453 Running Sum Of 1d Array
    ///  href = https://leetcode.com/problems/running-sum-of-1d-array/
    /// </summary>
    class P5453RunningSumOf1dArray {
        public static int[] RunningSum (int[] nums) {
            for (int i = 1; i < nums.Length; i++) {
                nums[i] += nums[i - 1];
            }

            return nums;
        }
    }
}
