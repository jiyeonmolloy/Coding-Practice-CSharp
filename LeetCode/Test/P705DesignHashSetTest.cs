using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P705DesignHashSetTest {
        [TestMethod]
        public void MyHashSetTest () {
            P705DesignHashSet hashSet = new P705DesignHashSet();
            hashSet.Add(1);
            hashSet.Add(2);
            Assert.IsTrue(hashSet.Contains(1));    // returns true
            Assert.IsFalse(hashSet.Contains(3));    // returns false (not found)
            hashSet.Add(2);
            hashSet.Contains(2);    // returns true
            hashSet.Remove(2);
            Assert.IsFalse(hashSet.Contains(2));    // returns false (already removed)
        }
    }
}
