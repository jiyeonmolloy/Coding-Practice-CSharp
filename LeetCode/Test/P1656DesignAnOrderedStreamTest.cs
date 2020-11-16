using System.Collections.Generic;
using System.Linq;
using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1656DesignAnOrderedStreamTest {
        [TestMethod]
        public void OrderedStreamTest () {
            P1656DesignAnOrderedStream os = new P1656DesignAnOrderedStream(5);

            IList<string> expectedStream = new List<string>();
            Assert.IsTrue(expectedStream.SequenceEqual(os.Insert(3, "ccccc")));

            expectedStream = new List<string>() { "aaaaa" };
            Assert.IsTrue(expectedStream.SequenceEqual(os.Insert(1, "aaaaa")));

            expectedStream = new List<string>() { "bbbbb", "ccccc" };
            Assert.IsTrue(expectedStream.SequenceEqual(os.Insert(2, "bbbbb")));

            expectedStream = new List<string>();
            Assert.IsTrue(expectedStream.SequenceEqual(os.Insert(5, "eeeee")));

            expectedStream = new List<string>() { "ddddd", "eeeee" };
            Assert.IsTrue(expectedStream.SequenceEqual(os.Insert(4, "ddddd")));
        }
    }
}
