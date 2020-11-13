using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P310 Minimum Height Trees
    ///  href = https://leetcode.com/problems/minimum-height-trees/
    /// </summary>
    class P310MinimumHeightTrees {
        public static IList<int> FindMinHeightTrees (int n, int[][] edges) {
            if (n < 2) {
                List<int> centroids = new List<int>();
                for (int i = 0; i < n; i++) {
                    centroids.Add(i);
                }
                return centroids;
            }

            List<HashSet<int>> neighbours = new List<HashSet<int>>();
            for (int i = 0; i < n; i++) {
                neighbours.Add(new HashSet<int>());
            }

            int start, end;
            foreach (int[] edge in edges) {
                start = edge[0];
                end = edge[1];
                neighbours[start].Add(end);
                neighbours[end].Add(start);
            }

            List<int> leaves = new List<int>();
            for (int i = 0; i < n; i++) {
                if (neighbours[i].Count == 1) {
                    leaves.Add(i);
                }
            }

            int remainingNodes = n;
            List<int> newLeaves;
            while (remainingNodes > 2) {
                remainingNodes -= leaves.Count;
                newLeaves = new List<int>();

                foreach (int leaf in leaves) {
                    foreach (int neighbour in neighbours[leaf]) {
                        neighbours[neighbour].Remove(leaf);
                        if (neighbours[neighbour].Count == 1) {
                            newLeaves.Add(neighbour);
                        }
                    }
                }

                leaves = newLeaves;
            }

            return leaves;
        }
    }
}
