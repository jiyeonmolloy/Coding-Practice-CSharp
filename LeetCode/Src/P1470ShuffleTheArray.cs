using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1470 Shuffle The Array. href = https://leetcode.com/problems/shuffle-the-array/
    /// </summary>
    class P1470ShuffleTheArray {
        public static int[] Shuffle (int[] nums, int n) {
            int move;
            int count = 1;
            int value;
            List<int> list = nums.ToList();
            for (int i = n; i < nums.Length; i++) {
                move = n - count;
                value = list[i];
                list.RemoveAt(i);
                list.Insert(i - move, value);
                count++;
            }

            return list.ToArray();
        }
    }
}
