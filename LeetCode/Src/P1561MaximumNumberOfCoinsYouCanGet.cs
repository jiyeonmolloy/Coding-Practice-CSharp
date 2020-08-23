using System;

namespace LeetCode.Src {
    /// <summary>
    /// P1561 Maximum Number Of Coins You Can Get
    ///  href = https://leetcode.com/problems/maximum-number-of-coins-you-can-get/
    /// </summary>
    class P1561MaximumNumberOfCoinsYouCanGet {
        public static int MaxCoins (int[] piles) {
            int size = piles.Length;
            int lowestCount = size / 3;

            Array.Sort(piles);

            int result = 0;
            for (int i = lowestCount; i < piles.Length; i += 2) {
                result += piles[i];
            }

            return result;
        }
    }
}
