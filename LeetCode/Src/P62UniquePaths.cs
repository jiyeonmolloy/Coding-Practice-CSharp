
namespace LeetCode.Src {
    /// <summary>
    /// P62 Unique Paths
    ///  href = https://leetcode.com/problems/unique-paths/
    /// </summary>
    class P62UniquePaths {
        public static int UniquePaths (int m, int n) {
            if (m == 1 || n == 1) {
                return 1;
            }

            int[,] dp = new int[m + 1, n + 1];
            dp[1, 1] = 1;

            for (int i = 1; i <= m; i++) {
                for (int j = 1; j <= n; j++) {
                    if (i == 1 && j == 1) {
                        continue;
                    }

                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }

            return dp[m, n];
        }
    }
}
