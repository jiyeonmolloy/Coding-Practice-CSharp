
namespace LeetCode.Src {
    class P338CountingBits {
        /// <summary>
        /// P338 Counting Bits. href = https://leetcode.com/problems/counting-bits/
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int[] CountBits (int num) {
            int[] dp = new int[num + 1];
            dp[0] = 0;
            for (int i = 1; i < num + 1; i++) {
                if (i % 2 != 0) {
                    dp[i] = dp[i - 1] + 1; // odd
                } else {
                    dp[i] = dp[i / 2]; // even
                }
            }
            return dp;
        }
    }
}
