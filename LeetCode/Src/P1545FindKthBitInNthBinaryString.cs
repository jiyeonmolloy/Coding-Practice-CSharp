using System;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1545 Find Kth Bit In Nth Binary
    ///  href = https://leetcode.com/problems/find-kth-bit-in-nth-binary-string/
    /// </summary>
    class P1545FindKthBitInNthBinaryString {
        public static char FindKthBit (int n, int k) {
            string si = "0";

            while (si.Length < k) {
                si += CreateBinaryString(si);
            }

            return si[k - 1];
        }

        private static string CreateBinaryString (string binaryString) {
            char[] output = new char[binaryString.Length];

            for (int i = 0; i < binaryString.Length; i++) {
                output[i] = binaryString[i] == '0' ? '1' : '0';
            }

            return "1" + new String(output.Reverse().ToArray());
        }
    }
}
