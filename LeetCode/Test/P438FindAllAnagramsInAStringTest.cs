using System.Collections.Generic;
using System.Linq;
using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P438FindAllAnagramsInAStringTest {
        [TestMethod]
        public void FindAllAnagramsInAString () {
            string s = "cbaebabacd";
            string p = "abc";

            IList<int> indexList = new List<int> { 0, 6 };

            Assert.IsTrue(indexList.SequenceEqual(P438FindAllAnagramsInAString.FindAnagrams(s, p)));

            s = "abab";
            p = "ab";

            indexList = new List<int> { 0, 1, 2 };

            Assert.IsTrue(indexList.SequenceEqual(P438FindAllAnagramsInAString.FindAnagrams(s, p)));
        }

        [TestMethod]
        public void FindNoAnagramsInAString () {
            string s = "";
            string p = "a";

            IList<int> indexList = new List<int>();

            Assert.IsTrue(indexList.SequenceEqual(P438FindAllAnagramsInAString.FindAnagrams(s, p)));
        }
    }
}
