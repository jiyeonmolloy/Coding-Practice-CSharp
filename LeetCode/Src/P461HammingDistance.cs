using System;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P461 Hamming Distance
    ///  href = https://leetcode.com/problems/hamming-distance/
    /// </summary>
    class P461HammingDistance {
        public static int HammingDistance (int x, int y) {
            return Convert.ToString(x ^ y, 2).Count(b => b == '1');
        }
    }
}
