using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1582 Special Positions In A Binary Matrix
    ///  href = https://leetcode.com/problems/special-positions-in-a-binary-matrix/
    /// </summary>
    class P1582SpecialPositionsInABinaryMatrix {
        public static int NumSpecial (int[][] mat) {
            int rows = mat.Length;
            int cols = mat[0].Length;
            int result = 0;

            List<int> currentRow = new List<int>();
            int targetCol = 0;
            bool validCol = false;
            for (int i = 0; i < rows; i++) {
                currentRow = mat[i].ToList();
                validCol = false;
                if (currentRow.Count(x => x == 1) == 1) {
                    // iterate vertically through column to validate
                    targetCol = currentRow.IndexOf(1);
                    for (int j = 0; j < rows; j++) {
                        if (mat[j][targetCol] == 1) {
                            if (validCol) {
                                validCol = false;
                                break;
                            }
                            validCol = true;
                        }
                    }

                    if (validCol) {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
