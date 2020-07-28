
namespace LeetCode.Src {
    /// <summary>
    /// P258 Add Digits
    ///  href = https://leetcode.com/problems/add-digits/
    /// </summary>
    class P258AddDigits {
        public static int AddDigits (int num) {
            if (num <= 0) {
                return num;
            }

            int remainder = num % 9;
            return remainder == 0 ? 9 : remainder;
        }
    }
}
