using System;
using System.Collections.Generic;

namespace LeetCode.Src {
    class P525ContiguousArray {
        /// <summary>
        /// P525 Contiguous Array. href = https://leetcode.com/problems/contiguous-array/
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int FindMaxLength (int[] nums) {
            int maxLength = 0;
            Dictionary<int, int> visited = new Dictionary<int, int>(); // count : index
            int count = 0;

            visited.Add(count, -1);

            for (int i = 0; i < nums.Length; i++) {
                count += nums[i] == 0 ? -1 : 1;

                if (visited.ContainsKey(count)) {
                    maxLength = Math.Max(maxLength, i - visited[count]);
                } else {
                    visited.Add(count, i);
                }
            }

            return maxLength;
        }
    }
}
