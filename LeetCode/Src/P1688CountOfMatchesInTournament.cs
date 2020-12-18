
namespace LeetCode.Src {
    /// <summary>
    /// P1688 Count Of Matches In Tournament
    /// href = https://leetcode.com/problems/count-of-matches-in-tournament/
    /// </summary>
    class P1688CountOfMatchesInTournament {
        public static int NumberOfMatches (int n) {
            int matches = 0;
            while (n != 1) {
                if (n % 2 == 0) {
                    matches += n / 2;
                    n = n / 2;
                } else {
                    matches += (n - 1) / 2;
                    n = (n - 1) / 2 + 1;
                }
            }

            return matches;
        }
    }
}
