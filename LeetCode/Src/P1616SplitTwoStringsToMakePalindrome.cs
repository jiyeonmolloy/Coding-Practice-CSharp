
namespace LeetCode.Src {
    /// <summary>
    /// P1616 Split Two Strings To Make Palindrome
    ///  href = https://leetcode.com/problems/split-two-strings-to-make-palindrome/
    /// </summary>
    class P1616SplitTwoStringsToMakePalindrome {
        public static bool CheckPalindromeFormation (string a, string b) {
            int aCount = 0;
            bool isAPalindrome = true;
            int bCount = 0;
            bool isBPalindrome = true;
            int j = a.Length - 1;

            for (int i = 0; i < a.Length; i++) {
                if (a[i] == b[j] && isAPalindrome) {
                    aCount++;
                } else {
                    if (isAPalindrome) {
                        if (CheckPalindrome(i, j, a) || CheckPalindrome(i, j, b)) {
                            return true;
                        }

                        isAPalindrome = false;
                    }
                }


                if (b[i] == a[j] && isBPalindrome) {
                    bCount++;
                } else {
                    if (isBPalindrome) {
                        if (CheckPalindrome(i, j, a) || CheckPalindrome(i, j, b)) {
                            return true;
                        }

                        isBPalindrome = false;
                    }
                }

                if (!isAPalindrome && !isBPalindrome) {
                    int half = a.Length / 2;
                    if (aCount > half || bCount > half) {
                        return true;
                    }
                    break;
                }

                j--;
            }

            return false;
        }

        private static bool CheckPalindrome (int start, int end, string target) {
            for (int i = start; i < target.Length / 2; i++) {
                if (target[i] != target[end]) {
                    return false;
                }

                end--;
            }

            return true;
        }
    }
}
