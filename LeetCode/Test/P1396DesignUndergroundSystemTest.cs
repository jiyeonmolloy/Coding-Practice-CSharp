using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Src;

namespace LeetCode.Test {
    [TestClass]
    public class P1396DesignUndergroundSystemTest {
        [TestMethod]
        public void UndergroundSystemTest () {
            P1396DesignUndergroundSystem undergroundSystem = new P1396DesignUndergroundSystem();
            undergroundSystem.CheckIn(45, "Leyton", 3);
            undergroundSystem.CheckIn(32, "Paradise", 8);
            undergroundSystem.CheckIn(27, "Leyton", 10);
            undergroundSystem.CheckOut(45, "Waterloo", 15);
            undergroundSystem.CheckOut(27, "Waterloo", 20);
            undergroundSystem.CheckOut(32, "Cambridge", 22);
            Assert.AreEqual(14.00000, undergroundSystem.GetAverageTime("Paradise", "Cambridge"));
            Assert.AreEqual(11.00000, undergroundSystem.GetAverageTime("Leyton", "Waterloo"));
            undergroundSystem.CheckIn(10, "Leyton", 24);
            Assert.AreEqual(11.00000, undergroundSystem.GetAverageTime("Leyton", "Waterloo"));
            undergroundSystem.CheckOut(10, "Waterloo", 38);
            Assert.AreEqual(12.00000, undergroundSystem.GetAverageTime("Leyton", "Waterloo"));
        }
    }
}
