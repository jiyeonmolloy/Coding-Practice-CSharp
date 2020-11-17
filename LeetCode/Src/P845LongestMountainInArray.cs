using System;

namespace LeetCode.Src {
    /// <summary>
    ///  P845 Longest Mountain In Array
    ///  href = https://leetcode.com/problems/longest-mountain-in-array/
    /// </summary>
    class P845LongestMountainInArray {
        public static int LongestMountain (int[] A) {
            if (A.Length < 3) {
                return 0;
            }

            bool peak = false;
            bool climb = false;
            int count = 0;
            int max = 0;
            int previousPoint, currentPoint;
            for (int i = 1; i < A.Length; i++) {
                previousPoint = A[i - 1];
                currentPoint = A[i];

                if (climb) {
                    if (currentPoint > previousPoint && !peak) {
                        count++;
                        continue;
                    }

                    if (currentPoint < previousPoint) {
                        peak = true;
                        count++;
                        continue;
                    }

                    count++;

                    if (peak) {
                        max = Math.Max(max, count);
                    }

                    if (currentPoint > previousPoint) {
                        count = 1;
                    } else {
                        count = 0;
                        climb = false;
                    }
                    peak = false;
                    continue;
                }

                if (currentPoint <= previousPoint) continue;

                count = 1;
                climb = true;
            }

            return peak ? Math.Max(max, count + 1) : max;
        }
    }
}
