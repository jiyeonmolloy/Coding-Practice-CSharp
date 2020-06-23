using LeetCode.Src.Common;

namespace LeetCode.Src {
    /// <summary>
    /// P222 Count Complete Tree Nodes
    /// href = https://leetcode.com/problems/count-complete-tree-nodes/
    /// </summary>
    class P222CountCompleteTreeNodes :  TreeNode {
        public static int CountNodes (TreeNode root) {
            if (root == null) {
                return 0;
            }

            int leftCount = CountNodes(root.left);
            int rightCount = CountNodes(root.right);

            return leftCount + rightCount + 1;
        }
    }
}
