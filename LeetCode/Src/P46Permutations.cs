using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P46 Permutations
    ///  href = https://leetcode.com/problems/permutations/
    /// </summary>
    class P46Permutations {
        public static IList<IList<int>> Permute (int[] nums) {
            int length = nums.Length;
            List<IList<int>> permutations = new List<IList<int>>();

            if (length == 0) {
                return permutations;
            }

            Dfs(nums, length, new bool[length], new List<int>(), permutations);

            return permutations;
        }

        private static void Dfs (int[] nums, int length, bool[] visited, IList<int> singlePermutation, IList<IList<int>> permutations) {
            if (singlePermutation.Count == length) {
                permutations.Add(new List<int>(singlePermutation));
            } else {
                for (int i = 0; i < length; i++) {
                    if (visited[i]) continue;

                    singlePermutation.Add(nums[i]);
                    visited[i] = true;
                    Dfs(nums, length, visited, singlePermutation, permutations);
                    visited[i] = false;
                    singlePermutation.RemoveAt(singlePermutation.Count - 1);
                }
            }
        }
    }
}
