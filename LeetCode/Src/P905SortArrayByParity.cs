using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P905 Sort Array By Parity
    ///  href = https://leetcode.com/problems/sort-array-by-parity/
    /// </summary>
    class P905SortArrayByParity {
        public static int[] SortArrayByParity (int[] A) {
            int[] even = A.Where(x => x % 2 == 0).ToArray();
            int[] odd = A.Where(x => x % 2 == 1).ToArray();

            return even.Concat(odd).ToArray();
        }
    }
}
