using System.Collections.Generic;
using System.Linq;
using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P442FindAllDuplicatesInAnArrayTest {
        [TestMethod]
        public void FindDuplicatesTest () {
            IList<int> expected = new List<int>() { 2, 3 };
            Assert.IsTrue(expected.SequenceEqual(P442FindAllDuplicatesInAnArray.FindDuplicates(new int[8] { 4, 3, 2, 7, 8, 2, 3, 1 })));
        }
    }
}
