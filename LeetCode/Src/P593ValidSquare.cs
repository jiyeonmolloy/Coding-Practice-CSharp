using System;

namespace LeetCode.Src {
    /// <summary>
    /// P593 Valid Square
    ///  href = https://leetcode.com/problems/valid-square/
    /// </summary>
    class P593ValidSquare {
        public static bool ValidSquare (int[] p1, int[] p2, int[] p3, int[] p4) {
            int[][] points = new int[][] { p1, p2, p3, p4 };
            Array.Sort(points, (point1, point2) =>
                point2[0] == point1[0] ?
                    point1[1] - point2[1] : point1[0] - point2[0]);

            double dist01 = CalculateDistance(points[0], points[1]);
            double dist13 = CalculateDistance(points[1], points[3]);
            double dist32 = CalculateDistance(points[3], points[2]);
            double dist20 = CalculateDistance(points[2], points[0]);

            double dist03 = CalculateDistance(points[0], points[3]);
            double dist12 = CalculateDistance(points[1], points[2]);

            if (!(Math.Abs(dist01) > 0)) return false;

            return Math.Abs(dist01 - dist13) < 0.01 && Math.Abs(dist13 - dist32) < 0.01 && Math.Abs(dist32 - dist20) < 0.01 && Math.Abs(dist03 - dist12) < 0.01;
        }

        private static double CalculateDistance (int[] p1, int[] p2) {
            return (p2[1] - p1[1]) * (p2[1] - p1[1]) + (p2[0] - p1[0]) * (p2[0] - p1[0]);
        }
    }
}
