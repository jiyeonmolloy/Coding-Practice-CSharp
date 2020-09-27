using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1598CrawlerLogFolderTest {
        [TestMethod]
        public void MinOperationsTest () {
            Assert.AreEqual(2, P1598CrawlerLogFolder.MinOperations(new[] { "d1/", "d2/", "../", "d21/", "./" }));
            Assert.AreEqual(3, P1598CrawlerLogFolder.MinOperations(new[] { "d1/", "d2/", "./", "d3/", "../", "d31/" }));
            Assert.AreEqual(0, P1598CrawlerLogFolder.MinOperations(new[] { "d1/", "../", "../", "../" }));
        }
    }
}
