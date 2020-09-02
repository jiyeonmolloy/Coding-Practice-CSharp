using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P217 Contains Duplicate
    ///  href = https://leetcode.com/problems/contains-duplicate/submissions/
    /// </summary>
    class P217ContainsDuplicate {
        public static bool ContainsDuplicate (int[] nums) {
            HashSet<int> hashSet = new HashSet<int>(nums);
            return hashSet.Count != nums.Length;
        }
    }
}
