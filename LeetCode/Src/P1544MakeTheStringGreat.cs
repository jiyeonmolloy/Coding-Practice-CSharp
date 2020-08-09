using System;

namespace LeetCode.Src {
    /// <summary>
    /// P1544 Make The String Great
    ///  href = https://leetcode.com/problems/make-the-string-great/
    /// </summary>
    class P1544MakeTheStringGreat {
        public static string MakeGood (string s) {
            int index = 0;
            Char current, next;
            while (index <= s.Length - 2) {
                current = s[index];
                next = s[index + 1];
                if (Char.ToLower(current) == Char.ToLower(next)) {
                    if ((Char.IsUpper(current) && Char.IsLower(next)) || (Char.IsUpper(next) && Char.IsLower(current))) {
                        s = s.Remove(index, 2);

                        if (index == s.Length) {
                            break;
                        }

                        if (index != 0) {
                            index -= 1;
                        }

                        continue;
                    }
                }

                index++;
            }

            return s;
        }
    }
}
