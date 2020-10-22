
namespace LeetCode.Src {
    /// <summary>
    /// P74 Search A 2D Matrix
    ///  href = https://leetcode.com/problems/search-a-2d-matrix/
    ///  Key: Binary Search
    /// </summary>
    class P74SearchA2DMatrix {
        public static bool SearchMatrix (int[][] matrix, int target) {
            if (matrix.Length == 0 || matrix[0].Length == 0) {
                return false;
            }

            int rows = matrix.Length;
            int cols = matrix[0].Length;

            int left, right;
            for (int row = 0; row < rows; row++) {
                left = 0;
                right = cols - 1;

                if (target < matrix[row][left] || target > matrix[row][right]) continue;
                int mid;
                int current;
                while (left <= right) {
                    mid = left + ((right - left) / 2);
                    current = matrix[row][mid];

                    if (current == target) {
                        return true;
                    } else if (target < current) {
                        right = mid - 1;
                    } else if (target > current) {
                        left = mid + 1;
                    }
                }
            }

            return false;
        }
    }
}
