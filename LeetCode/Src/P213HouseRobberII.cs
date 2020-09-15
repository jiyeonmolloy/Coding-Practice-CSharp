using System;

namespace LeetCode.Src {
    /// <summary>
    /// P213 House Robber II
    ///  href = https://leetcode.com/problems/house-robber-ii/
    /// </summary>
    class P213HouseRobberII {
        public static int Rob (int[] nums) {
            switch (nums.Length) {
                case 0:
                    return 0;
                case 1:
                    return nums[0];
            }

            return Math.Max(FindMaximumMoney(0, nums.Length - 1, nums), FindMaximumMoney(1, nums.Length, nums));
        }

        private static int FindMaximumMoney (int start, int end, int[] nums) {
            int rob1 = 0;
            int rob2 = 0;

            int temp;
            for (int i = start; i < end; i++) {
                int n = nums[i];
                // rob1, rob2, n, n+1
                temp = Math.Max(n + rob1, rob2);
                rob1 = rob2;
                rob2 = temp;
            }

            return rob2;
        }
    }
}
