using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Src {
    /// <summary>
    /// P35 Search Insert Position
    ///  href = https://leetcode.com/problems/search-insert-position/
    /// </summary>
    class P35SearchInsertPosition {
        public static int SearchInsert (int[] nums, int target) {
            int left = 0;
            int right = nums.Length - 1;
            int mid;

            while (left <= right) {
                mid = left + ((right - left) / 2);

                if (nums[mid] == target) {
                    return mid;
                }

                if (nums[mid] > target) {
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            }

            return left;
        }
    }
}
