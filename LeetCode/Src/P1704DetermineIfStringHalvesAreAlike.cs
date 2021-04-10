using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1704 Determine If String Halves Are Alike
    /// href = https://leetcode.com/problems/determine-if-string-halves-are-alike/
    /// </summary>
    class P1704DetermineIfStringHalvesAreAlike {
        public static bool HalvesAreAlike (string s) {
            int half = s.Length / 2;
            string firstHalf = s.Substring(0, half);
            string secondHalf = s.Substring(half, half);

            int firstHalfVowelCount = 0;
            int secondHalfVowelCount = 0;
            for (int i = 0; i < half; i++) {
                if (IsVowel(firstHalf[i])) {
                    firstHalfVowelCount++;
                }

                if (IsVowel(secondHalf[i])) {
                    secondHalfVowelCount++;
                }
            }

            return firstHalfVowelCount == secondHalfVowelCount;
        }

        private static bool IsVowel (char c) {
            return "aeiouAEIOU".Contains(c);
        }
    }
}
