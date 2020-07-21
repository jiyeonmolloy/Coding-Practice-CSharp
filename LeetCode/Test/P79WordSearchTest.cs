using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P79WordSearchTest {
        [TestMethod]
        public void ExistTest () {
            char[][] wordMap = new char[3][] { new char[4] { 'A', 'B', 'C', 'E' }, new char[4] { 'S', 'F', 'C', 'S' }, new char[4] { 'A', 'D', 'E', 'E' } };

            Assert.IsTrue(P79WordSearch.Exist(wordMap, "ABCCED"));
            Assert.IsTrue(P79WordSearch.Exist(wordMap, "SEE"));
            Assert.IsFalse(P79WordSearch.Exist(wordMap, "ABCB"));
        }
    }
}
