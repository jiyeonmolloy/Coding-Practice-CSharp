using System;
using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P1615 Maximal Network Rank
    ///  href = https://leetcode.com/problems/maximal-network-rank/
    /// </summary>
    class P1615MaximalNetworkRank {
        public static int MaximalNetworkRank (int n, int[][] roads) {
            if (roads.Length == 0 || roads.Length == 1) {
                return roads.Length;
            }

            Dictionary<int, HashSet<int>> dictionary = new Dictionary<int, HashSet<int>>(n);
            int[] frequency = new int[n + 1];

            for (int i = 0; i < n; i++) {
                dictionary[i] = new HashSet<int>();
            }

            int city1;
            int city2;
            foreach (int[] road in roads) {
                city1 = road[0];
                city2 = road[1];

                frequency[city1]++;
                frequency[city2]++;

                dictionary[city1].Add(city2);
                dictionary[city2].Add(city1);
            }

            int max = 0;
            int current = 0;
            for (int i = 0; i < frequency.Length; i++) {
                for (int j = i + 1; j < frequency.Length; j++) {
                    current = frequency[i] + frequency[j];

                    if (dictionary[i].Contains(j)) {
                        current--;
                    }

                    max = Math.Max(current, max);
                }
            }

            return max;
        }
    }
}
