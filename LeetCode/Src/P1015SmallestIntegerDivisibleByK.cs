
namespace LeetCode.Src {
    /// <summary>
    /// P1015 Smallest Integer Divisible By K
    /// href = https://leetcode.com/problems/smallest-integer-divisible-by-k/
    /// </summary>
    class P1015SmallestIntegerDivisibleByK {
        public static int SmallestRepunitDivByK (int K) {
            if (K % 2 == 0 || K % 5 == 0) {
                return -1;
            }

            int N = 1;
            int length = 1;

            while (N % K != 0) {
                N = (N * 10 + 1) % K;
                length++;
            }

            return length;
        }
    }
}
