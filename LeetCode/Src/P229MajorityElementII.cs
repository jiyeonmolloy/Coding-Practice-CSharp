using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P229 Majority Element II
    ///  href = https://leetcode.com/problems/majority-element-ii/
    /// </summary>
    class P229MajorityElementII {
        public static IList<int> MajorityElement (int[] nums) {
            int limit = nums.Length / 3;
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            int target = 0;
            for (int i = 0; i < nums.Length; i++) {
                target = nums[i];
                if (dictionary.ContainsKey(target)) {
                    dictionary[target]++;
                } else {
                    dictionary.Add(target, 1);
                }
            }

            return dictionary.Where(x => x.Value > limit).Select(x => x.Key).ToList();
        }
    }
}
