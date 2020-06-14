using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P5453RunningSumOf1dArrayTest {
        [TestMethod]
        public void RunningSumTest () {
            CollectionAssert.AreEqual(new int[4] { 1, 3, 6, 10 }, P5453RunningSumOf1dArray.RunningSum(new int[4] { 1, 2, 3, 4 }));
            CollectionAssert.AreEqual(new int[5] { 1, 2, 3, 4, 5 }, P5453RunningSumOf1dArray.RunningSum(new int[5] { 1, 1, 1, 1, 1 }));
            CollectionAssert.AreEqual(new int[5] { 3, 4, 6, 16, 17 }, P5453RunningSumOf1dArray.RunningSum(new int[5] { 3, 1, 2, 10, 1 }));
        }
    }
}
