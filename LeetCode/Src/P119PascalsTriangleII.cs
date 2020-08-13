using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P119 Pascal's Triangle II
    ///  href = https://leetcode.com/problems/pascals-triangle-ii/
    /// </summary>
    class P119PascalsTriangleII {
        public static IList<int> GetRow (int rowIndex) {
            IList<int> previousRow = new List<int> {
                1
            };

            IList<int> row = new List<int> { 1 };
            for (int rowNumber = 1; rowNumber <= rowIndex; rowNumber++) {
                row = new List<int> { 1 };


                for (int i = 1; i < rowNumber; i++) {
                    row.Add(previousRow[i - 1] + previousRow[i]);
                }

                row.Add(1);
                previousRow.Clear();
                previousRow = row;
            }

            return row;
        }
    }
}
