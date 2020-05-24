
namespace LeetCode.Src {
    class P1456MaximumNumberOfVowelsInASubstringOfGivenLength {
        /// <summary>
        /// P1456 Maximum Number of Vowels in a Substring of Given Length. href = https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int MaxVowels (string s, int k) {
            int count = 0;

            // initialize vowel count
            for (int i = 0; i < k; i++) {
                if (IsVowel(s[i])) {
                    count++;
                }
            }

            int maxVowelCount = count;
            for (int i = k; i < s.Length; i++) {
                if (IsVowel(s[i - k])) {
                    count--;
                }

                if (IsVowel(s[i])) {
                    count++;
                }

                if (count > maxVowelCount) {
                    maxVowelCount = count;
                }
            }

            return maxVowelCount;
        }

        private static bool IsVowel (char c) {
            return "aeiou".IndexOf(c) >= 0;
        }
    }
}
