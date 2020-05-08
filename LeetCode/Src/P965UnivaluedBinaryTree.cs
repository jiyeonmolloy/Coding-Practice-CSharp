using LeetCode.Src.Common;

namespace LeetCode.Src {
    /// <summary>
    /// P965 Univalued Binary Tree. href = https://leetcode.com/problems/univalued-binary-tree/
    /// Key: DFS
    /// </summary>
    class P965UnivaluedBinaryTree : TreeNode {
        public static bool IsUnivalTree (TreeNode root) {
            return Dfs(root, root.val);
        }

        private static bool Dfs (TreeNode root, int val) {
            if (root == null) { // End of tree
                return true;
            }

            if (root.val != val) {
                return false;
            }

            return Dfs(root.left, val) && Dfs(root.right, val);
        }
    }
}
