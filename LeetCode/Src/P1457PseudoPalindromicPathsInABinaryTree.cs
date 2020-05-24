using LeetCode.Src.Common;

namespace LeetCode.Src {
    class P1457PseudoPalindromicPathsInABinaryTree : TreeNode {
        /// <summary>
        /// P1457 Pseudo-Palindromic Paths in a Binary Tree. href = https://leetcode.com/problems/pseudo-palindromic-paths-in-a-binary-tree/
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static int PseudoPalindromicPaths (TreeNode root) {
            int[] stateArray = new int[9];
            int result = 0;
            Dfs(root, stateArray, ref result);
            return result;
        }

        private static void Dfs (TreeNode root, int[] stateArray, ref int result) {
            if (root == null) { // End of tree
                return;
            }

            stateArray[root.val - 1]++;


            if (root.left == null && root.right == null) {
                if (IsPalindrome(stateArray)) {
                    result++;
                }
            } else {
                Dfs(root.left, stateArray, ref result);
                Dfs(root.right, stateArray, ref result);
            }

            stateArray[root.val - 1]--;
        }

        private static bool IsPalindrome (int[] stateArray) {
            // Only one not matching number 
            // All other numbers must be pairs (even number of appearance)
            int notMatching = 0;
            foreach (int state in stateArray) {
                if (state % 2 == 1) {
                    notMatching++;
                }
            }

            if (notMatching <= 1) {
                return true;
            }

            return false;
        }
    }
}
