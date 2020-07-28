using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1528 Shuffle String
    ///  href = https://leetcode.com/problems/shuffle-string/
    /// </summary>
    class P1528ShuffleString {
        public static string RestoreString (string s, int[] indices) {
            int size = indices.Length;
            char[] result = new char[size];

            for (int i = 0; i < size; i++) {
                result[indices[i]] = s.ElementAt(i);
            }

            return new string(result);
        }
    }
}
