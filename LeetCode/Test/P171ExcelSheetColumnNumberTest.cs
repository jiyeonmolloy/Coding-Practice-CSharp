using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P171ExcelSheetColumnNumberTest {
        [TestMethod]
        public void TitleToNumberTest () {
            Assert.AreEqual(1, P171ExcelSheetColumnNumber.TitleToNumber("A"));
            Assert.AreEqual(28, P171ExcelSheetColumnNumber.TitleToNumber("AB"));
            Assert.AreEqual(701, P171ExcelSheetColumnNumber.TitleToNumber("ZY"));
            Assert.AreEqual(703, P171ExcelSheetColumnNumber.TitleToNumber("AAA"));
        }
    }
}
