using System;
using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P1577 Number Of Ways Where Square Of Number Is Equal To Product Of Two Numbers
    ///  href = https://leetcode.com/problems/number-of-ways-where-square-of-number-is-equal-to-product-of-two-numbers/
    /// </summary>
    class P1577NumberOfWaysWhereSquareOfNumberIsEqualToProductOfTwoNumbers {
        public static int NumTriplets (int[] nums1, int[] nums2) {
            return CheckType(nums1, nums2) + CheckType(nums2, nums1);
        }

        private static int CheckType (int[] nums1, int[] nums2) {
            int count = 0;
            Int64 multiply;
            Dictionary<Int64, int> nums1Multiply = new Dictionary<Int64, int>();
            for (int i = 0; i < nums1.Length; i++) {
                Int64 power = Convert.ToInt64(nums1[i]) * Convert.ToInt64(nums1[i]);
                if (i == 0) {
                    for (int j = 0; j < nums2.Length; j++) {
                        for (int k = j + 1; k < nums2.Length; k++) {
                            multiply = (Convert.ToInt64(nums2[j]) * Convert.ToInt64(nums2[k]));
                            if (power == multiply) {
                                count++;
                            }

                            if (nums1Multiply.ContainsKey(multiply)) {
                                nums1Multiply[multiply]++;
                            } else {
                                nums1Multiply.Add(multiply, 1);
                            }

                        }
                    }
                } else {
                    if (nums1Multiply.ContainsKey(power)) {
                        count += nums1Multiply[power];
                    }
                }
            }

            return count;
        }
    }
}
