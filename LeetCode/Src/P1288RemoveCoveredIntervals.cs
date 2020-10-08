using System;

namespace LeetCode.Src {
    /// <summary>
    /// P1288 Remove Covered Intervals
    ///  href = https://leetcode.com/problems/remove-covered-intervals/
    /// </summary>
    class P1288RemoveCoveredIntervals {
        public static int RemoveCoveredIntervals (int[][] intervals) {
            Array.Sort(intervals, (x, y) => x[0] == y[0] ? y[1] - x[1] : x[0] - y[0]);
            int count = 0;
            int right = 0;

            foreach (int[] interval in intervals) {
                if (interval[1] <= right) continue;
                count++;
                right = interval[1];
            }

            return count;
        }
    }
}
