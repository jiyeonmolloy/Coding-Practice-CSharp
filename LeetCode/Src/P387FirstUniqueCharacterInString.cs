
namespace LeetCode.Src {
    /// <summary>
    /// P387 First Unique Character In String. href = https://leetcode.com/problems/first-unique-character-in-a-string/
    /// </summary>
    class P387FirstUniqueCharacterInString {
        public static int FirstUniqChar (string s) {
            bool isUniqueChar;
            string analyze = s;
            char analyzeChar;

            while (analyze.Length > 0) {
                isUniqueChar = true;
                analyzeChar = analyze[0];
                for (int i = 1; i < analyze.Length; i++) {
                    if (analyzeChar == analyze[i]) {
                        isUniqueChar = false;
                        break;
                    }
                }

                if (isUniqueChar) {
                    return s.IndexOf(analyzeChar);
                }

                analyze = analyze.Replace(analyzeChar.ToString(), string.Empty);
            }

            return -1;
        }
    }
}
