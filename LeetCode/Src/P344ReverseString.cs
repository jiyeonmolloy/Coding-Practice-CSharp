
namespace LeetCode.Src {
    /// <summary>
    /// P344 Reverse String. href = https://leetcode.com/problems/reverse-string/
    /// </summary>
    class P344ReverseString {
        public static char[] ReverseString (char[] s) {
            char temp;
            int length = s.Length;
            int endIndex;
            for (int i = 0; i < length / 2; i++) {
                endIndex = length - 1 - i;

                if (s[i].Equals(s[endIndex])) {
                    continue;
                }

                temp = s[i];
                s[i] = s[endIndex];
                s[endIndex] = temp;
            }

            return s;
        }
    }
}
