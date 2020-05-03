using System;

namespace LeetCode.Src {
    /// <summary>
    /// P1423: Maximum Points You Can Obtain From Cards. href = https://leetcode.com/problems/maximum-points-you-can-obtain-from-cards/
    /// </summary>
    class P1423MaximumPointsYouCanObtainFromCards {
        public static int MaxScore (int[] cardPoints, int k) {
            int cardSize = cardPoints.Length;
            int maxScore = 0;

            // Get k number of cards from the right and add to maximum score
            for (int i = cardSize - k; i < cardSize; i++) {
                maxScore += cardPoints[i];
            }

            // Sliding window
            int score = maxScore;
            for (int i = 0; i < k; i++) {
                score -= cardPoints[cardSize - k + i];
                score += cardPoints[i];
                maxScore = Math.Max(maxScore, score);
            }

            return maxScore;
        }
    }
}
