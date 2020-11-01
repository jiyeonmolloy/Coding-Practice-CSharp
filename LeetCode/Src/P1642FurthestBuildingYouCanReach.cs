using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P1642 Furthest Building You Can Reach
    ///  href = https://leetcode.com/problems/furthest-building-you-can-reach/
    /// </summary>
    class P1642FurthestBuildingYouCanReach {
        public static int FurthestBuilding (int[] heights, int bricks, int ladders) {
            SortedSet<(int, int)> brickHistory = new SortedSet<(int diff, int index)>();
            int difference;
            int totalBricks = 0;
            int i;
            for (i = 1; i < heights.Length; i++) {
                if (heights[i - 1] >= heights[i]) continue;

                difference = heights[i] - heights[i - 1];
                if ((totalBricks + difference) <= bricks) {
                    brickHistory.Add((difference, i));
                    totalBricks += difference;
                } else {
                    if (ladders > 0) {
                        // Remove largest brick history and use ladder
                        if (brickHistory.Count > 0) {
                            brickHistory.Add((difference, i));
                            totalBricks -= brickHistory.Max.Item1;
                            brickHistory.Remove(brickHistory.Max);
                            totalBricks += difference;
                        }

                        ladders--;
                    } else {
                        return i - 1;
                    }
                }
            }

            return i - 1;
        }
    }
}
