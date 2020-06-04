using System;
using System.Collections.Generic;

namespace LeetCode.Src {
    class P1TwoSum {
        /// <summary>
        /// P1 Two Sum. href = https://leetcode.com/problems/two-sum/
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSum (int[] nums, int target) {
            Dictionary<int, int> complementDict = new Dictionary<int, int>(); // Key: Complement, Value: Index
            int complement;
            for (int i = 0; i < nums.Length; i++) {
                complement = target - nums[i];
                if (complementDict.ContainsKey(complement)) {
                    return new int[] { complementDict[complement], i };
                } else {
                    complementDict[nums[i]] = i;
                }
            }

            throw new ArgumentException("Parameter does not provide a two sum solution", "nums");
        }
    }
}
