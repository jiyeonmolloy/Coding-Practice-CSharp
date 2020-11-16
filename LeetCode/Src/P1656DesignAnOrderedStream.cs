using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    ///  P1656 Design An Ordered Stream
    ///  href = https://leetcode.com/problems/design-an-ordered-stream/
    /// </summary>
    class P1656DesignAnOrderedStream {
        private Dictionary<int, string> dictionary;
        private int pointer;

        public P1656DesignAnOrderedStream (int n) {
            dictionary = new Dictionary<int, string>();
            pointer = 1;
        }

        public IList<string> Insert (int id, string value) {
            List<string> result = new List<string>();
            dictionary.Add(id, value);

            int index = pointer;
            bool add = false;
            while (true) {
                if (dictionary.ContainsKey(index)) {
                    result.Add(dictionary[index]);
                    index++;
                    add = true;
                    continue;
                }

                if (add) {
                    pointer = index;
                }

                break;
            }

            return result;
        }
    }
}
