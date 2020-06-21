using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1487MakingFileNamesUniqueTest {
        [TestMethod]
        public void GetFolderNamesTest () {
            CollectionAssert.AreEqual(new string[4] { "pes", "fifa", "gta", "pes(2019)" }, P1487MakingFileNamesUnique.GetFolderNames(new string[4] { "pes", "fifa", "gta", "pes(2019)" }));
            CollectionAssert.AreEqual(new string[4] { "gta", "gta(1)", "gta(2)", "avalon" }, P1487MakingFileNamesUnique.GetFolderNames(new string[4] { "gta", "gta(1)", "gta", "avalon" }));
            CollectionAssert.AreEqual(new string[3] { "Will", "Will(4)", "Will(1)" }, P1487MakingFileNamesUnique.GetFolderNames(new string[3] { "Will", "Will(4)", "Will" }));
            CollectionAssert.AreEqual(new string[5] { "onepiece", "onepiece(1)", "onepiece(2)", "onepiece(3)", "onepiece(4)" }, P1487MakingFileNamesUnique.GetFolderNames(new string[5] { "onepiece", "onepiece(1)", "onepiece(2)", "onepiece(3)", "onepiece" }));
            CollectionAssert.AreEqual(new string[4] { "wano", "wano(1)", "wano(2)", "wano(3)" }, P1487MakingFileNamesUnique.GetFolderNames(new string[4] { "wano", "wano", "wano", "wano" }));
            CollectionAssert.AreEqual(new string[4] { "kaido", "kaido(1)", "kaido(2)", "kaido(1)(1)" }, P1487MakingFileNamesUnique.GetFolderNames(new string[4] { "kaido", "kaido(1)", "kaido", "kaido(1)" }));
            CollectionAssert.AreEqual(new string[5] { "kaido", "kaido(1)", "kaido(2)", "kaido(1)(1)", "kaido(2)(1)" }, P1487MakingFileNamesUnique.GetFolderNames(new string[5] { "kaido", "kaido(1)", "kaido", "kaido(1)", "kaido(2)" }));
        }
    }
}
