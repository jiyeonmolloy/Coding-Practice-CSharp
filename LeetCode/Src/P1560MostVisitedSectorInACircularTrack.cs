using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1560 Most Visited Sector In A Circular Track
    ///  href = https://leetcode.com/problems/most-visited-sector-in-a-circular-track/
    /// </summary>
    class P1560MostVisitedSectorInACircularTrack {
        public static IList<int> MostVisited (int n, int[] rounds) {
            Dictionary<int, int> visited = new Dictionary<int, int>();

            int start, end;
            int max = -1;
            for (int i = 0; i < rounds.Length - 1; i++) {
                start = rounds[i];
                end = rounds[i + 1];

                if (i != 0) {
                    start++;

                    if (start > n) {
                        start = 1;
                    }
                }

                while (start != end) {
                    visited = AddToDictionary(visited, start);

                    if (visited[start] > max) {
                        max = visited[start];
                    }

                    start++;

                    if (start > n) {
                        start = 1;
                    }
                }

                visited = AddToDictionary(visited, start);

                if (visited[start] > max) {
                    max = visited[start];
                }
            }

            return visited.Where(s => s.Value == max).Select(x => x.Key).OrderBy(i => i).ToList();
        }

        private static Dictionary<int, int> AddToDictionary (Dictionary<int, int> dictionary, int key) {
            if (dictionary.ContainsKey(key)) {
                dictionary[key]++;
            } else {
                dictionary.Add(key, 1);
            }

            return dictionary;
        }
    }
}
