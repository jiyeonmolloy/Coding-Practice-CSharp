using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1472DesignBrowserHistoryTest {
        [TestMethod]
        public void BrowserHistoryTest () {
            string homepage = "leetcode.com";
            P1472DesignBrowserHistory browserHistory = new P1472DesignBrowserHistory(homepage);
            browserHistory.Visit("google.com");
            browserHistory.Visit("facebook.com");
            browserHistory.Visit("youtube.com");
            Assert.AreEqual("facebook.com", browserHistory.Back(1));
            Assert.AreEqual("google.com", browserHistory.Back(1));
            Assert.AreEqual("facebook.com", browserHistory.Forward(1));
            browserHistory.Visit("linkedin.com");
            Assert.AreEqual("linkedin.com", browserHistory.Forward(2));
            Assert.AreEqual("google.com", browserHistory.Back(2));
            Assert.AreEqual("leetcode.com", browserHistory.Back(7));
        }
    }
}
