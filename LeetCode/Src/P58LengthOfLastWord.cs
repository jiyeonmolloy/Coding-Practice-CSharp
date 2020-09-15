
namespace LeetCode.Src {
    /// <summary>
    /// P58 Length Of Last Word
    ///  href = https://leetcode.com/problems/length-of-last-word/
    /// </summary>
    class P58LengthOfLastWord {
        public static int LengthOfLastWord (string s) {
            if (s.Length == 0) return 0;

            int length = 0;
            bool foundWord = false;
            for (int i = s.Length - 1; i >= 0; i--) {
                if (s[i].Equals(' ')) {
                    if (!foundWord) {
                        continue;
                    }
                    return length;
                }

                foundWord = true;
                length++;
            }

            return length;
        }
    }
}
