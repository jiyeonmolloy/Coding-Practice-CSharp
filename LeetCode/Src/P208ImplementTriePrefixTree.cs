using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P208 Implement Trie (Prefix Tree)
    ///  href = https://leetcode.com/problems/implement-trie-prefix-tree/
    /// </summary>
    class P208ImplementTriePrefixTree {
        private Node root;

        /** Initialize your data structure here. */
        public P208ImplementTriePrefixTree () {
            root = new Node();
        }

        /** Inserts a word into the trie. */
        public void Insert (string word) {
            Node current = root;

            foreach (char character in word) {
                if (!current.Next.ContainsKey(character)) {
                    current.Next.Add(character, new Node());
                }
                current = current.Next[character];
            }

            current.IsCompleteWord = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search (string word) {
            Node current = root;

            foreach (char character in word) {
                if (!current.Next.ContainsKey(character)) {
                    return false;
                }
                current = current.Next[character];
            }

            return current.IsCompleteWord;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith (string prefix) {
            Node current = root;

            foreach (char character in prefix) {
                if (!current.Next.ContainsKey(character)) {
                    return false;
                }
                current = current.Next[character];
            }

            return true;
        }
    }

    public class Node {
        public Dictionary<char, Node> Next;
        public bool IsCompleteWord;

        public Node () {
            Next = new Dictionary<char, Node>();
            IsCompleteWord = false;
        }
    }
}
