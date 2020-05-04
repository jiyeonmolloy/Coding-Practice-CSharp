using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P383RansomNoteTest {
        [TestMethod]
        public void CanConstructRansomNote () {
            Assert.IsTrue(P383RansomNote.CanConstruct("aa", "aab"));
        }

        [TestMethod]
        public void CannoteConstructRansomNote () {
            Assert.IsFalse(P383RansomNote.CanConstruct("a", "b"));
            Assert.IsFalse(P383RansomNote.CanConstruct("aa", "ab"));
        }
    }
}
