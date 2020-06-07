using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P1472 Design Browser History. href = https://leetcode.com/problems/design-browser-history/
    /// </summary>
    class P1472DesignBrowserHistory {
        private int index;
        private List<string> browserList = new List<string>();

        public P1472DesignBrowserHistory (string homepage) {
            browserList.Clear();
            browserList.Add(homepage);
            index = 0;
        }

        public void Visit (string url) {
            int size = browserList.Count;

            if (size > index + 1) {
                // Remove forward history
                browserList.RemoveRange(index + 1, browserList.Count - index - 1);
            }

            browserList.Add(url);
            index++;
        }

        public string Back (int steps) {
            index -= steps;

            if (index < 0) {
                index = 0;
            }

            return browserList[index];
        }

        public string Forward (int steps) {
            int size = browserList.Count;
            index += steps;

            if (index >= browserList.Count) {
                index = size - 1;
            }

            return browserList[index];
        }
    }
}
