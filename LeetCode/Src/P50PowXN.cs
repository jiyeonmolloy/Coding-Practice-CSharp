
namespace LeetCode.Src {
    /// <summary>
    /// P50 Pow(x, n)
    ///  href = https://leetcode.com/problems/powx-n/
    /// </summary>
    class P50PowXN {
        public static double MyPow (double x, int n) {
            if (n == 0) {
                return 1;
            }

            long power = n;
            if (power < 0) {
                x = 1 / x;
                power = -power;
            }

            double result = 1;
            double target = x;
            for (long i = power; i > 0; i /= 2) {
                if (i % 2 == 1) {
                    result *= target;
                }

                target *= target;
            }

            return result;
        }
    }
}
