using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P56 Mergen Intervals
    ///  href = https://leetcode.com/problems/merge-intervals/
    /// </summary>
    class P56MergenIntervals {
        public static int[][] Merge (int[][] intervals) {
            if (intervals.Length <= 1) {
                return intervals;
            }

            intervals = intervals.OrderBy(x => x[0]).ThenBy(y => y[1]).ToArray();
            List<int[]> merged = new List<int[]>() { new[] { intervals[0][0], intervals[0][1] } };

            int start, end, largestInterval;
            for (int i = 1; i < intervals.Length; i++) {
                int[] interval = intervals[i];
                start = interval[0];
                end = interval[1];
                largestInterval = merged[merged.Count - 1][1];
                if (start > largestInterval) {
                    merged.Add(interval);
                } else {
                    merged[merged.Count - 1][1] = Math.Max(largestInterval, end);
                }
            }

            return merged.ToArray();
        }
    }
}
