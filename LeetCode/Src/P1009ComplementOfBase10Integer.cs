
namespace LeetCode.Src {
    /// <summary>
    /// P1009 Complement Of Base 10 Integer
    /// Same question as P476 Number Complement
    ///  href = https://leetcode.com/problems/complement-of-base-10-integer/
    /// </summary>
    class P1009ComplementOfBase10Integer {
        public static int BitwiseComplement (int N) {
            if (N == 0) {
                return 1;
            }

            int complement = 0;
            int factor = 1;

            while (N > 0) {
                complement += factor * (N % 2 == 0 ? 1 : 0);
                N /= 2;
                factor *= 2;
            }

            return complement;
        }
    }
}
