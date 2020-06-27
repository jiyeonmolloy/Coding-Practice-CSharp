using LeetCode.Src.Common;

namespace LeetCode.Src {
    /// <summary>
    /// P129 Sum Root to Leaf Numbers
    ///  href = https://leetcode.com/problems/sum-root-to-leaf-numbers/
    /// </summary>
    class P129SumRootToLeafNumbers : TreeNode {
        public static int SumNumbers (TreeNode root) {
            return Dfs(root, 0); ;
        }

        private static int Dfs (TreeNode root, int val) {
            if (root == null) {
                return 0;
            }

            int sum = val * 10 + root.val;
            if (root.left == null && root.right == null) {
                return sum;
            }

            return Dfs(root.left, sum) + Dfs(root.right, sum);
        }
    }
}
