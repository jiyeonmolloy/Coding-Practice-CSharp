using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Src {
    class P540SingleElementInASortedArray {
        /// <summary>
        /// P540 Single Element In A Sorted Array. href = https://leetcode.com/problems/single-element-in-a-sorted-array/
        /// Key: 
        /// XOR of a number with itself is 0
        /// XOR of a number with 0 is itself
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SingleNonDuplicate (int[] nums) {
            int nonDuplicate = nums[0];

            for (int i = 1; i < nums.Length; i++) {
                nonDuplicate = nonDuplicate ^ nums[i];
            }

            return nonDuplicate;
        }
    }
}
