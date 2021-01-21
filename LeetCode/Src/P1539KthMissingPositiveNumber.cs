using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P1539 Kth Missing Positive Number
    /// href = https://leetcode.com/problems/kth-missing-positive-number/
    /// </summary>
    class P1539KthMissingPositiveNumber {
        public static int FindKthPositive (int[] arr, int k) {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach (var element in arr) {
                dictionary.Add(element, 1);
            }

            int index = 1;
            while (k > 0) {
                if (!dictionary.ContainsKey(index)) {
                    k--;
                }
                index++;
            }
            return index - 1;
        }
    }
}
