using System;

namespace LeetCode.Src {
    /// <summary>
    /// P1672 Richest Customer Wealth
    /// href = https://leetcode.com/problems/richest-customer-wealth/
    /// </summary>
    class P1672RichestCustomerWealth {
        public static int MaximumWealth (int[][] accounts) {
            int max = 0;
            for (int i = 0; i < accounts.Length; i++) {
                int count = 0;
                for (int j = 0; j < accounts[0].Length; j++) {
                    count += accounts[i][j];
                }

                max = Math.Max(count, max);
            }

            return max;
        }
    }
}
