using System;

namespace LeetCode.Src {
    /// <summary>
    /// P198 House Robber
    ///  href = https://leetcode.com/problems/house-robber/
    /// </summary>
    class P198HouseRobber {
        public static int Rob (int[] nums) {
            switch (nums.Length) {
                case 0:
                    return 0;
                case 1:
                    return nums[0];
            }

            int rob1 = 0;
            int rob2 = 0;

            int temp;
            foreach (int n in nums) {
                // rob1, rob2, n, n+1
                temp = Math.Max(n + rob1, rob2);
                rob1 = rob2;
                rob2 = temp;
            }

            return rob2;
        }
    }
}
