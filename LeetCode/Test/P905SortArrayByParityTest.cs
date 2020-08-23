using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P905SortArrayByParityTest {
        [TestMethod]
        public void SortArrayByParityTest () {
            CollectionAssert.AreEqual(new int[4] { 2, 4, 3, 1 }, P905SortArrayByParity.SortArrayByParity(new int[4] { 3, 1, 2, 4 }));
        }
    }
}
