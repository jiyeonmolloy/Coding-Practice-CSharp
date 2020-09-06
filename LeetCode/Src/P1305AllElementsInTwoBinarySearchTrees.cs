using System.Collections.Generic;
using System.Linq;
using LeetCode.Src.Common;

namespace LeetCode.Src {
    /// <summary>
    /// P1305 All Elements In Two Binary Search Trees
    ///  href = https://leetcode.com/problems/all-elements-in-two-binary-search-trees/
    /// </summary>
    class P1305AllElementsInTwoBinarySearchTrees : TreeNode {
        public static IList<int> GetAllElements (TreeNode root1, TreeNode root2) {
            IList<int> order = new List<int>();
            Dfs(root1, order);
            IList<int> order2 = new List<int>();
            Dfs(root2, order2);

            return order.Concat(order2).OrderBy(x => x).ToList(); ;
        }

        private static void Dfs (TreeNode root, IList<int> list) {
            if (root == null) {
                return;
            }

            Dfs(root.left, list);
            Dfs(root.right, list);

            list.Add(root.val);
        }
    }
}
