using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Src {
    /// <summary>
    /// P316 Remove Duplicate Letters
    ///  href = https://leetcode.com/problems/remove-duplicate-letters/
    /// </summary>
    class P316RemoveDuplicateLetters {
        public static string RemoveDuplicateLetters (string s) {
            int[] frequency = new int[26];

            foreach (char character in s) {
                frequency[character - 'a']++;
            }

            Stack<char> stack = new Stack<char>(); // Resulting characters
            bool[] visited = new bool[26]; // Visited characters

            int index;
            foreach (char character in s) {
                index = character - 'a';
                frequency[index]--;

                if (visited[index]) {
                    continue;
                }

                while (stack.Count > 0 && frequency[stack.Peek() - 'a'] > 0 && character < stack.Peek()) {
                    visited[stack.Pop() - 'a'] = false;
                }

                stack.Push(character);
                visited[index] = true;
            }

            StringBuilder stringBuilder = new StringBuilder();

            while (stack.Count > 0) {
                stringBuilder.Append(stack.Pop());
            }

            return new string(stringBuilder.ToString().Reverse().ToArray());
        }
    }
}
