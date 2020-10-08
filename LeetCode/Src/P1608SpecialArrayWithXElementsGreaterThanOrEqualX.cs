using System;

namespace LeetCode.Src {
    /// <summary>
    /// P1608 Special Array With X Elements Greater Than Or Equal X
    ///  href = https://leetcode.com/problems/special-array-with-x-elements-greater-than-or-equal-x/
    /// </summary>
    class P1608SpecialArrayWithXElementsGreaterThanOrEqualX {
        public static int SpecialArray (int[] nums) {
            Array.Sort(nums, (a, b) => b.CompareTo(a));

            int special = 0;
            while (special < nums.Length && nums[special] > special) {
                special += 1;
            }

            if (special < nums.Length && nums[special] == special) {
                return -1;
            }

            return special;
        }
    }
}
