
namespace LeetCode.Src {
    /// <summary>
    /// P1816 Truncate Sentence
    /// href = https://leetcode.com/problems/truncate-sentence/
    /// </summary>
    class P1816TruncateSentence {
        public static string TruncateSentence (string s, int k) {
            string[] words = s.Split(' ');
            string sentence = words[0];

            if (words.Length == 1) {
                return s;
            }

            for (int i = 1; i < k; i++) {
                sentence += ' ' + words[i];
            }

            return sentence;
        }
    }
}
