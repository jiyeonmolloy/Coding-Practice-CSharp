using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P118 Pascals Triangle
    ///  href = https://leetcode.com/problems/pascals-triangle/
    /// </summary>
    class P118PascalsTriangle {
        public static IList<IList<int>> Generate (int numRows) {
            IList<IList<int>> pascalsTriangle = new List<IList<int>>() { };
            if (numRows == 0) {
                return pascalsTriangle;
            }

            // Add first row of Pascal's Triangle
            pascalsTriangle.Add(new List<int>() { 1 });

            IList<int> previousRow;
            IList<int> row;
            for (int rowNumber = 1; rowNumber < numRows; rowNumber++) {
                previousRow = pascalsTriangle[rowNumber - 1];
                row = new List<int>();

                for (int i = 0; i <= rowNumber; i++) {
                    if (i == 0 || i == rowNumber) {
                        row.Add(1);
                    } else {
                        row.Add(previousRow[i - 1] + previousRow[i]);
                    }
                }

                pascalsTriangle.Add(row);
            }

            return pascalsTriangle;
        }
    }
}
