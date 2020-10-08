using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P933 Number Of Recent Call
    ///  href = https://leetcode.com/problems/number-of-recent-calls/
    /// </summary>
    class P933NumberOfRecentCalls {
        private List<int> history;

        public P933NumberOfRecentCalls () {
            history = new List<int>();
        }

        public int Ping (int t) {
            history.Add(t);
            history = history.Where(x => x >= t - 3000).ToList();
            return history.Count;
        }
    }
}
