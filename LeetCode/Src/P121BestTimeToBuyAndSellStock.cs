using System;

namespace LeetCode.Src {
    /// <summary>
    /// P121 Best Time To Buy and Sell Stock
    ///  Key: Kadane's Algorithm
    ///  href = https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// </summary>
    class P121BestTimeToBuyAndSellStock {
        public static int MaxProfit (int[] prices) {
            int size = prices.Length;
            if (size == 0 || size == 1) {
                return 0;
            }

            int buyPrice = prices[0];
            int maxProfit = 0;

            int currentPrice;
            for (int i = 1; i < prices.Length; i++) {
                currentPrice = prices[i];

                if (currentPrice < buyPrice) {
                    buyPrice = currentPrice;
                } else {
                    maxProfit = Math.Max(currentPrice - buyPrice, maxProfit);
                }
            }

            return maxProfit;
        }
    }
}
