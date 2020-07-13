using LeetCode.Src.Common;

namespace LeetCode.Src {
    /// <summary>
    /// P100 Same Tree
    ///  href = https://leetcode.com/problems/same-tree/
    /// </summary>
    class P100SameTree : TreeNode{
        public static bool IsSameTree (TreeNode p, TreeNode q) {
            if (p == null || q == null) {
                return p == q;
            }

            if (p.val != q.val) {
                return false;
            }

            return IsSameTree(p.right, q.right) && IsSameTree(p.left, q.left);
        }
    }
}
