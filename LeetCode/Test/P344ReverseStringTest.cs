using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P344ReverseStringTest {
        [TestMethod]
        public void ReverseString () {
            CollectionAssert.AreEqual(new char[5] { 'o', 'l', 'l', 'e', 'h' }, P344ReverseString.ReverseString(new char[5] { 'h', 'e', 'l', 'l', 'o' }));
            CollectionAssert.AreEqual(new char[4] { 'y', 'b', 'o', 'T' }, P344ReverseString.ReverseString(new char[4] { 'T', 'o', 'b', 'y' }));
        }
    }
}
