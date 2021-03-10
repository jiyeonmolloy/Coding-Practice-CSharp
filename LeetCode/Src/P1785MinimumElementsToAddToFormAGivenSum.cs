using System;

namespace LeetCode.Src {
    /// <summary>
    /// P1785 Minimum Elements To Add To Form A Given Sum
    /// href = https://leetcode.com/problems/minimum-elements-to-add-to-form-a-given-sum/
    /// </summary>
    class P1785MinimumElementsToAddToFormAGivenSum {
        public static int MinElements (int[] nums, int limit, int goal) {
            // sum of array
            Int64 sum = 0;
            foreach (var num in nums) {
                sum += num;
            }

            // difference to goal
            Int64 difference = Math.Abs(goal - sum);

            // perform modulus to get number of operations
            Int64 operations = difference / limit;
            Int64 modulus = difference % limit;

            if (modulus > 0) {
                return (int)operations + 1;
            }

            return (int)operations;
        }
    }
}
