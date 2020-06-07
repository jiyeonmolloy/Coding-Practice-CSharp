using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1470ShuffleTheArrayTest {
        [TestMethod]
        public void ShuffleTest () {
            CollectionAssert.AreEqual(new int[6] { 2, 3, 5, 4, 1, 7 }, P1470ShuffleTheArray.Shuffle(new int[6] { 2, 5, 1, 3, 4, 7 }, 3));
            CollectionAssert.AreEqual(new int[8] { 1, 4, 2, 3, 3, 2, 4, 1 }, P1470ShuffleTheArray.Shuffle(new int[8] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4));
        }
    }
}
