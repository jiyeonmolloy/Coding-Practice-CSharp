using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1471 The K Strongest Values In An Array. href = https://leetcode.com/problems/the-k-strongest-values-in-an-array/
    /// </summary>
    class P1471TheKStrongestValuesInAnArray {
        public static int[] GetStrongest (int[] arr, int k) {
            int size = arr.Length;
            // Sort array in asc order
            List<int> list = arr.ToList();
            list.Sort();

            // Calculate median
            int position = (size - 1) / 2;
            int median = list[position];

            // Find strength value for each element
            int[] strongest = new int[k];
            int leftIndex = 0;
            int rightIndex = size - 1;
            int leftValue, rightValue;

            int count = 0;
            while (count != k) {
                leftValue = list[leftIndex];
                rightValue = list[rightIndex];

                if (LeftValueIsStronger(leftValue, rightValue, median)) {
                    strongest[count] = leftValue;
                    leftIndex++;
                } else {
                    strongest[count] = rightValue;
                    rightIndex--;
                }

                count++;
            }

            // Return strongest elements
            return strongest;
        }

        private static bool LeftValueIsStronger (int leftValue, int rightValue, int median) {
            int value1Strength = (leftValue - median) * -1; // left of median, so always negative
            int value2Strength = rightValue - median; // right of median, so always positive

            if (value1Strength == value2Strength) {
                return false;
            }

            return value1Strength > value2Strength;
        }
    }
}
