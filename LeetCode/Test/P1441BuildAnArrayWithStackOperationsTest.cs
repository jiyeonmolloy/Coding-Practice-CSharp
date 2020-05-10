using System.Collections.Generic;
using System.Linq;
using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1441BuildAnArrayWithStackOperationsTest {
        [TestMethod]
        public void BuildAnArrayWithStackOperations () {
            int[] test = new int[2] { 1, 3 };
            IList<string> target = new string[4] { "Push", "Push", "Pop", "Push" };
            Assert.IsTrue(P1441BuildAnArrayWithStackOperations.BuildArray(test, 3).SequenceEqual(target));

            test = new int[3] { 1, 2, 3 };
            target = new string[3] { "Push", "Push", "Push" };
            Assert.IsTrue(P1441BuildAnArrayWithStackOperations.BuildArray(test, 3).SequenceEqual(target));

            test = new int[2] { 1, 2 };
            target = new string[2] { "Push", "Push" };
            Assert.IsTrue(P1441BuildAnArrayWithStackOperations.BuildArray(test, 4).SequenceEqual(target));

            test = new int[3] { 2, 3, 4 };
            target = new string[5] { "Push", "Pop", "Push", "Push", "Push" };
            Assert.IsTrue(P1441BuildAnArrayWithStackOperations.BuildArray(test, 4).SequenceEqual(target));
        }
    }
}
