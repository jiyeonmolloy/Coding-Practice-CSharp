
namespace LeetCode.Src {
    /// <summary>
    /// P1576 Replace All Question Marks To Avoid Consecutive Repeating Characters
    ///  href = https://leetcode.com/problems/replace-all-s-to-avoid-consecutive-repeating-characters/
    /// </summary>
    class P1576ReplaceAllQuestionMarksToAvoidConsecutiveRepeatingCharacters {
        public static string ModifyString (string s) {
            if (s.Length == 1) {
                return s.Equals("?") ? "a" : s;
            }

            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] modified = s.ToCharArray();

            for (int i = 0; i < modified.Length; i++) {
                if (modified[i] != '?') continue;

                if (i == 0) {
                    if (modified[i + 1] != 'a') {
                        modified[i] = 'a';
                    } else {
                        modified[i] = 'b';
                    }
                } else if (i == (modified.Length - 1)) {
                    foreach (char a in alpha) {
                        if (modified[i - 1] == a) continue;
                        modified[i] = a;
                        break;
                    }
                } else {
                    foreach (char a in alpha) {
                        if (modified[i - 1] == a || modified[i + 1] == a) continue;
                        modified[i] = a;
                        break;
                    }
                }
            }

            return new string(modified);
        }
    }
}
