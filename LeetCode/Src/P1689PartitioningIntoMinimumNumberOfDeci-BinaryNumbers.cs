using System;

namespace LeetCode.Src {
    /// <summary>
    /// P1689 Partitioning Into Minimum Number Of Deci_Binary Numbers
    /// href = https://leetcode.com/problems/partitioning-into-minimum-number-of-deci-binary-numbers/
    /// </summary>
    class P1689PartitioningIntoMinimumNumberOfDeci_BinaryNumbers {
        public static int MinPartitions (string n) {
            int target = 0;
            int max = 0;

            foreach (var number in n) {
                target = number - '0';
                if (target == 9) {
                    return 9;
                }
                max = Math.Max(target, max);
            }

            return max;
        }
    }
}
