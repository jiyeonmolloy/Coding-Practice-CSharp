using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P1689PartitioningIntoMinimumNumberOfDeci_BinaryNumbersTest {
        [TestMethod]
        public void MinPartitionsTest () {
            Assert.AreEqual(3, P1689PartitioningIntoMinimumNumberOfDeci_BinaryNumbers.MinPartitions("32"));
            Assert.AreEqual(8, P1689PartitioningIntoMinimumNumberOfDeci_BinaryNumbers.MinPartitions("82734"));
            Assert.AreEqual(9, P1689PartitioningIntoMinimumNumberOfDeci_BinaryNumbers.MinPartitions("27346209830709182346"));
        }
    }
}
