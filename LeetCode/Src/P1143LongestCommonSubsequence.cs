using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Src {
    /// <summary>
    /// P1143 Longest Common Subsequence
    ///  href = https://leetcode.com/problems/longest-common-subsequence/
    /// </summary>
    class P1143LongestCommonSubsequence {
        public static int LongestCommonSubsequence (string text1, string text2) {
            int text1Length = text1.Length;
            int text2Length = text2.Length;

            int[,] dp = new int[text1Length + 1, text2Length + 1];

            for (int i = 1; i <= text1Length; i++) {
                for (int j = 1; j <= text2Length; j++) {
                    if (text1[i - 1].Equals(text2[j - 1])) {
                        dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j - 1] + 1);
                    } else {
                        dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
                    }
                }
            }

            return dp[text1Length, text2Length];
        }
    }
}
