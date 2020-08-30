using System;

namespace LeetCode.Src {
    /// <summary>
    /// P470 Implement Rand10 Using Rand7
    ///  href = https://leetcode.com/problems/implement-rand10-using-rand7/
    /// Key: Rejection Sampling
    /// </summary>
    class P470ImplementRand10UsingRand7 {
        private static int Rand7 () {
            return new Random().Next(1, 7);
        }

        public static int Rand10 () {
            int row;
            int col;
            int index = 100;

            while (index > 40) {
                row = Rand7();
                col = Rand7();
                // Generate value between 0 .. 49
                // Ignore values between 41 .. 49 (Only from 1 .. 9)
                index = col + (row - 1) * 7;
            }

            return 1 + (index - 1) % 10;
        }
    }
}
