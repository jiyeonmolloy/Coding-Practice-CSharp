using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P208ImplementTriePrefixTreeTest {
        [TestMethod]
        public void MyHashSetTest () {
            P208ImplementTriePrefixTree trie = new P208ImplementTriePrefixTree();
            trie.Insert("apple");
            trie.Search("apple");   // returns true
            trie.Search("app");     // returns false
            trie.StartsWith("app"); // returns true
            trie.Insert("app");
            trie.Search("app");     // returns true
        }
    }
}
