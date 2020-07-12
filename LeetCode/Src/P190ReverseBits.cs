
namespace LeetCode.Src {
    /// <summary>
    /// P190 Reverse Bits
    ///  href = https://leetcode.com/problems/reverse-bits/
    /// </summary>
    class P190ReverseBits {
        public static uint ReverseBits (uint n) {
            uint reversed = 0;

            uint nLast;
            for (int i = 0; i < 32; i++) {
                reversed <<= 1;
                nLast = n & 1;
                reversed |= nLast;
                n >>= 1;
            }

            return reversed;
        }
    }
}
