using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P20 Valid Parentheses
    /// href = https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    class P20ValidParentheses {
        public static bool IsValid (string s) {
            Stack<char> stack = new Stack<char>();

            char openingBracket;
            char target;
            foreach (char bracket in s) {
                target = bracket;

                if (IsOpeningBracket(target)) {
                    stack.Push(target);
                    continue;
                }

                if (stack.Count == 0) {
                    return false;
                }

                openingBracket = stack.Peek();

                if (IsMatchingBracket(openingBracket, target)) {
                    stack.Pop();
                    continue;
                }

                return false;
            }

            return stack.Count == 0;
        }

        public static bool IsOpeningBracket (char bracket) {
            return bracket.Equals('(') || bracket.Equals('[') || bracket.Equals('{');
        }

        public static bool IsMatchingBracket (char openingBracket, char closingBracket) {
            switch (openingBracket) {
                case '(':
                    return closingBracket.Equals(')');
                case '[':
                    return closingBracket.Equals(']');
                case '{':
                    return closingBracket.Equals('}');
                default:
                    return false;
            }
        }
    }
}
