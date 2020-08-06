using System;
using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P442 Find All Duplicates in an Array
    ///  href = https://leetcode.com/problems/find-all-duplicates-in-an-array/
    /// </summary>
    class P442FindAllDuplicatesInAnArray {
        public static IList<int> FindDuplicates (int[] nums) {
            IList<int> duplicateList = new List<int>();
            int index;

            for (int i = 0; i < nums.Length; i++) {
                index = Math.Abs(nums[i]) - 1;
                if (nums[index] < 0) {
                    duplicateList.Add(Math.Abs(index + 1));
                }

                nums[index] = -nums[index];
            }

            return duplicateList;
        }
    }
}
