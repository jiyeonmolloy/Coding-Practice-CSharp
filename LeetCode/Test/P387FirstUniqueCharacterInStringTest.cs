using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P387FirstUniqueCharacterInStringTest {
        [TestMethod]
        public void FindFirstUniqueCharacterInString () {
            Assert.AreEqual(0, P387FirstUniqueCharacterInString.FirstUniqChar("leetcode"));
            Assert.AreEqual(2, P387FirstUniqueCharacterInString.FirstUniqChar("loveleetcode"));
        }

        [TestMethod]
        public void FindNoUniqueCharacterInEmptyString () {
            Assert.AreEqual(-1, P387FirstUniqueCharacterInString.FirstUniqChar(""));
        }
    }
}
