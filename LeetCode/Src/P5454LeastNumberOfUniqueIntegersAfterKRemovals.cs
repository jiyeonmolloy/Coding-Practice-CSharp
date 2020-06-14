using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P5454 Least Number Of Unique Integers After K Removals
    ///  href = https://leetcode.com/problems/least-number-of-unique-integers-after-k-removals/
    /// </summary>
    class P5454LeastNumberOfUniqueIntegersAfterKRemovals {
        public static int FindLeastNumOfUniqueInts (int[] arr, int k) {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int total = arr.Length;
            int target;
            for (int i = 0; i < total; i++) {
                target = arr[i];
                if (dict.ContainsKey(target)) {
                    dict[target]++;
                } else {
                    dict.Add(target, 1);
                }
            }

            List<KeyValuePair<int, int>> orderedList = dict.OrderBy(x => x.Value).ToList();

            int lastValue;
            while (k > 0) {
                lastValue = orderedList[0].Value;

                k -= lastValue;

                if (k >= 0) {
                    orderedList.RemoveAt(0);
                }
            }

            return orderedList.Count;
        }
    }
}
