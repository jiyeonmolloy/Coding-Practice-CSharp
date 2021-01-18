using System;
using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P1695 Maximum Erasure Value
    /// href = https://leetcode.com/problems/maximum-erasure-value/
    /// </summary>
    class P1695MaximumErasureValue {
        public static int MaximumUniqueSubarray (int[] nums) {
            int n = nums.Length;
            Queue<int> queue = new Queue<int>();

            int target;
            int current = 0;
            int max = 0;
            for (int i = 0; i < n; i++) {
                target = nums[i];

                int remove = 0;

                if (queue.Contains(target)) { // contains
                    while (queue.Peek() != target) {
                        remove = queue.Dequeue();
                        current -= remove;
                    }

                    current -= queue.Dequeue();
                }


                current += target;
                queue.Enqueue(target);

                max = Math.Max(max, current);
            }

            return max;
        }
    }
}
