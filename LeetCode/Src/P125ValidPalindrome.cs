using System;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P125 Valid Palindrome
    ///  href = https://leetcode.com/problems/valid-palindrome/
    /// </summary>
    class P125ValidPalindrome {
        public static bool IsPalindrome (string s) {
            char[] palindromeArray = s.Trim().ToLower().ToCharArray().Where(Char.IsLetterOrDigit).ToArray();

            if (palindromeArray.Length == 0) {
                return true;
            }

            int start = 0;
            int end = palindromeArray.Length - 1;

            while (start < end) {
                if (palindromeArray[start].Equals(palindromeArray[end])) {
                    start++;
                    end--;
                } else {
                    return false;
                }
            }

            return true;
        }
    }
}
