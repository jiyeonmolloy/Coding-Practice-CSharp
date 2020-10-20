using System;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1626 Best Team With No Conflicts
    ///  href = https://leetcode.com/problems/best-team-with-no-conflicts/
    ///  Key: Top-down DP
    /// </summary>
    class P1626BestTeamWithNoConflicts {
        public static int BestTeamScore (int[] scores, int[] ages) {
            int size = scores.Length;

            scores = Enumerable.Range(0, scores.Length)
                .Select(t => (t, score: scores[t], age: ages[t]))
                .OrderByDescending(p => p.age)
                .ThenByDescending(p => p.score)
                .Select(p => p.score)
                .ToArray();

            int max;
            int[] dp = new int[size];
            for (int i = 0; i < size; i++) {
                max = scores[i];
                for (int j = i - 1; j >= 0; j--) {
                    if (scores[j] >= scores[i]) {
                        max = Math.Max(max, dp[j] + scores[i]);
                    }
                }

                dp[i] = max;
            }

            return dp.Max();
        }
    }
}
