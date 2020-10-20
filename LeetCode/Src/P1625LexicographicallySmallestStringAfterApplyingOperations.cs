using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Src {
    /// <summary>
    /// P1625 Lexicographically Smallest String After Applying Operations
    ///  href = https://leetcode.com/problems/lexicographically-smallest-string-after-applying-operations/
    /// </summary>
    class P1625LexicographicallySmallestStringAfterApplyingOperations {
        private HashSet<String> history;
        private String min;

        public string FindLexSmallestString (string s, int a, int b) {
            history = new HashSet<String>();
            min = s;
            history.Add(s);
            DFS(s, a, b);
            return min;
        }

        private void DFS (string s, int a, int b) {
            String result = Add(s, a);
            if (history.Add(result)) {
                if (String.Compare(result, min, StringComparison.Ordinal) < 0) {
                    min = result;
                }
                DFS(result, a, b);
            }

            result = Rotate(s, b);
            if (history.Add(result)) {
                if (String.Compare(result, min, StringComparison.Ordinal) < 0) {
                    min = result;
                }
                DFS(result, a, b);
            }
        }

        private string Rotate (string s, int index) {
            if (s.Length == 1) {
                return s;
            }
            int size = s.Length - index;
            return s.Substring(size) + s.Substring(0, size);
        }

        private string Add (string s, int add) {
            StringBuilder stringBuilder = new StringBuilder();
            int sum;
            for (int i = 0; i < s.Length; i++) {
                sum = (int)Char.GetNumericValue(s[i]);
                if (i % 2 == 1) {
                    sum = (sum + add) % 10;
                }
                stringBuilder.Append(sum);
            }

            return stringBuilder.ToString();
        }
    }
}
