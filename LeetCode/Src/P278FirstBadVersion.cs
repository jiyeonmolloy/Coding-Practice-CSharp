

namespace LeetCode.Src {
    /// <summary>
    /// P278 First Bad Version. href = https://leetcode.com/problems/first-bad-version/
    /// Key: Binary Search
    /// </summary>
    class P278FirstBadVersion {
        private int badVersion;

        public P278FirstBadVersion(int badVersion) {
            this.badVersion = badVersion;
        }

        public int FirstBadVersion (int n) {
            int left = 1;
            int badVersion = n;

            while (left < badVersion) {
                int mid = left + ((badVersion - left) / 2);

                if (IsBadVersion(mid)) {
                    badVersion = mid;
                } else {
                    left = mid + 1;
                }
            }

            return badVersion;
        }

        private bool IsBadVersion (int version) {
            if (version >= badVersion) {
                return true;
            } else {
                return false;
            }
        }
    }
}
