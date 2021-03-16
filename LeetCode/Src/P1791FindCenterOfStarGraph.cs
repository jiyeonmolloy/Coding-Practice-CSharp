
namespace LeetCode.Src {
    /// <summary>
    /// P1791 Find Center Of Star Graph
    /// href = https://leetcode.com/problems/find-center-of-star-graph/
    /// </summary>
    class P1791FindCenterOfStarGraph {
        public static int FindCenter (int[][] edges) {
            int firstCandidate = edges[0][0];
            int secondCandidate = edges[0][1];

            bool firstIteration = true;
            foreach (int[] edge in edges) {
                if (firstIteration) {
                    firstIteration = false;
                    continue;
                }

                if (firstCandidate == edge[0] || firstCandidate == edge[1]) {
                    return firstCandidate;
                }

                if (secondCandidate == edge[0] || secondCandidate == edge[1]) {
                    return secondCandidate;
                }
            }

            // shouldn't reach here  
            return 0;
        }
    }
}
