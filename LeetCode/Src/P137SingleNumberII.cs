using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P137 Single Number II
    ///  href = https://leetcode.com/problems/single-number-ii/
    /// </summary>
    class P137SingleNumberII {
        public static int SingleNumber (int[] nums) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int target;

            for (int i = 0; i < nums.Length; i++) {
                target = nums[i];
                if (dict.ContainsKey(target)) {
                    dict[target]++;
                } else {
                    dict.Add(target, 1);
                }
            }

            return dict.First(x => x.Value == 1).Key;
        }
    }
}
