using System;

namespace LeetCode.Src {
    /// <summary>
    /// P1007 Minimum Domino Rotations For Equal Row
    ///  href = https://leetcode.com/problems/minimum-domino-rotations-for-equal-row/
    /// </summary>
    class P1007MinimumDominoRotationsForEqualRow {
        public static int MinDominoRotations (int[] A, int[] B) {
            int[] aFrequency = new int[6];
            int[] bFrequency = new int[6];
            int[] swap = new int[6];
            int size = A.Length;

            for (int i = 0; i < size; i++) {
                aFrequency[A[i] - 1]++;
                bFrequency[B[i] - 1]++;
                if (A[i] == B[i]) {
                    swap[A[i] - 1]++;
                }
            }

            int swaps;
            int minSwaps = size;
            for (int i = 0; i < 6; i++) {
                if (aFrequency[i] + bFrequency[i] - swap[i] != size) continue;
                swaps = Math.Min(aFrequency[i], bFrequency[i]) - swap[i];
                minSwaps = Math.Min(swaps, minSwaps);
            }

            return minSwaps == size ? -1 : minSwaps;
        }
    }
}
