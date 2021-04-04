
namespace LeetCode.Src {
    /// <summary>
    /// P9 Palindrome Number
    /// href = https://leetcode.com/problems/palindrome-number/
    /// </summary>
    class P9PalindromeNumber {
        public static bool IsPalindrome (int x) {
            if (x < 0) {
                return false;
            }

            string number = x.ToString();
            int length = number.Length;

            if (length == 1) {
                return true;
            }

            int middleIndex = number.Length / 2;
            int left, right;
            if (length % 2 == 0) {
                left = middleIndex - 1;
                right = middleIndex;
            } else {
                left = middleIndex - 1;
                right = middleIndex + 1;
            }

            while (left >= 0 && right < number.Length) {
                if (!number[left].Equals(number[right])) {
                    return false;
                }

                left--;
                right++;
            }

            return true;
        }

    }
}
