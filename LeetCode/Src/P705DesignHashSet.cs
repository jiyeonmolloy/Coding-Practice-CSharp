
namespace LeetCode.Src {
    /// <summary>
    /// P705 Design HashSet
    ///  href = https://leetcode.com/problems/design-hashset/
    /// </summary>
    class P705DesignHashSet {
        private bool[] record;

        /** Initialize your data structure here. */
        public P705DesignHashSet () {
            record = new bool[1000001];
        }

        public void Add (int key) {
            record[key] = true;
        }

        public void Remove (int key) {
            record[key] = false;
        }

        /** Returns true if this set contains the specified element */
        public bool Contains (int key) {
            return record[key];
        }
    }
}
