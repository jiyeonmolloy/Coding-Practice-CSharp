using System;

namespace LeetCode.Src {
    /// <summary>
    /// P299 Bulls And Cows
    ///  href = https://leetcode.com/problems/bulls-and-cows/
    /// </summary>
    class P299BullsAndCows {
        public static string GetHint (string secret, string guess) {
            int bulls = 0;
            int cows = 0;
            int[] secretFreq = new int[10];
            int[] guessFreq = new int[10];

            int secretInt, guessInt;
            for (int i = 0; i < secret.Length; i++) {
                if (secret[i].Equals(guess[i])) {
                    bulls++;
                    continue;
                }

                secretInt = Convert.ToInt32(new string(secret[i], 1));
                guessInt = Convert.ToInt32(new string(guess[i], 1));

                secretFreq[secretInt]++;
                guessFreq[guessInt]++;

                if (secretFreq[guessInt] >= guessFreq[guessInt]) {
                    cows += guessFreq[guessInt];
                    secretFreq[guessInt] -= guessFreq[guessInt];
                    guessFreq[guessInt] = 0;
                } else if (secretFreq[guessInt] > 0) {
                    cows += secretFreq[guessInt];
                    guessFreq[guessInt] -= secretFreq[guessInt];
                    secretFreq[guessInt] = 0;
                }

                if (guessFreq[secretInt] >= secretFreq[secretInt]) {
                    cows += secretFreq[secretInt];
                    guessFreq[secretInt] -= secretFreq[secretInt];
                    secretFreq[secretInt] = 0;
                } else if (guessFreq[secretInt] > 0) {
                    cows += guessFreq[secretInt];
                    secretFreq[secretInt] -= guessFreq[secretInt];
                    guessFreq[secretInt] = 0;
                }
            }

            return bulls.ToString() + "A" + cows.ToString() + "B";
        }
    }
}
