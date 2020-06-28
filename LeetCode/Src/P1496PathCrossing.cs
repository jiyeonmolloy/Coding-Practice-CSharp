using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1496 Path Crossing
    ///  href = https://leetcode.com/problems/path-crossing/
    /// </summary>
    class P1496PathCrossing {
        public static bool IsPathCrossing (string path) {
            HashSet<List<int>> matrix = new HashSet<List<int>>();
            matrix.Add(new List<int>() { 0, 0 });

            List<int> lastPosition;
            List<int> position = new List<int>();

            const int verticalIndex = 0;
            const int horizontalIndex = 1;
            foreach (char direction in path) {
                lastPosition = matrix.Last();

                switch (direction) {
                    case 'N':
                        position = new List<int>() { lastPosition[verticalIndex] + 1, lastPosition[horizontalIndex] };
                        break;
                    case 'E':
                        position = new List<int>() { lastPosition[verticalIndex], lastPosition[horizontalIndex] + 1 };
                        break;
                    case 'S':
                        position = new List<int>() { lastPosition[verticalIndex] - 1, lastPosition[horizontalIndex] };
                        break;
                    case 'W':
                        position = new List<int>() { lastPosition[verticalIndex], lastPosition[horizontalIndex] - 1 };
                        break;
                }

                if (matrix.Any(x => x[verticalIndex] == position[verticalIndex] && x[horizontalIndex] == position[horizontalIndex])) {
                    return true;
                }

                matrix.Add(position);
            }

            return false;
        }
    }
}
