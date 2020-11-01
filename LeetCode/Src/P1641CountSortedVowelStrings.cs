
namespace LeetCode.Src {
    /// <summary>
    /// P1641 Count Sorted Vowel Strings
    ///  href = https://leetcode.com/problems/count-sorted-vowel-strings/
    /// </summary>
    class P1641CountSortedVowelStrings {
        public static int CountVowelStrings (int n) {
            int[,] dp = new int[n, 5]; // starting vowel : number of vowels that can be changed

            if (n == 1) {
                return 5;
            }

            for (int index = 0; index < 5; index++) {
                // If only one vowel is being changed, the frequency is 1
                dp[0, index] = 1;
            }

            int freq;
            int totalFreq = 0;
            for (int i = 1; i < n; i++) {
                for (int j = 0; j < 5; j++) {
                    freq = 0;
                    for (int k = j; k < 5; k++) {
                        freq += dp[i - 1, k];
                    }

                    dp[i, j] = freq;
                    if (i == n - 1) {
                        totalFreq += dp[i, j];
                    }
                }
            }

            return totalFreq;
        }
    }
}
