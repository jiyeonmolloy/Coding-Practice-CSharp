using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1422 Maximum Score After Splitting a String. href = https://leetcode.com/problems/maximum-score-after-splitting-a-string/
    /// </summary>
    class P1422MaximumScoreAfterSplittingAString {
        public static int MaxScore (string s) {
            List<int> score = s.Select(x => int.Parse(x.ToString())).ToList();

            int leftScore = 0;
            int rightScore = 0;

            HashSet<int> scoreList = new HashSet<int>();
            for (int i = 1; i < score.Count; i++) {
                leftScore = score.Take(i).ToList().Count(x => x == 0);
                rightScore = score.Skip(i).ToList().Count(x => x == 1);

                scoreList.Add(leftScore + rightScore);
            }

            return scoreList.Max();
        }
    }
}
