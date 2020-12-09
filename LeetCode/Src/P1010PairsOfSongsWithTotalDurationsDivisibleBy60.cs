
namespace LeetCode.Src {
    /// <summary>
    /// P1010 Pairs Of Songs With Total Durations Divisible By 60
    /// href = https://leetcode.com/problems/pairs-of-songs-with-total-durations-divisible-by-60/
    /// </summary>
    class P1010PairsOfSongsWithTotalDurationsDivisibleBy60 {
        public static int NumPairsDivisibleBy60 (int[] time) {
            int[] remaining = new int[60];
            int count = 0;
            int target = 0;
            foreach (int current in time) {
                target = current % 60;
                if (target == 0) {
                    count += remaining[0];
                } else {
                    count += remaining[60 - target];
                }

                remaining[target]++;
            }

            return count;
        }
    }
}
