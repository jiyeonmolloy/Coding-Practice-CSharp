using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Test {
    [TestClass]
    public class P332ReconstructItineraryTest {
        [TestMethod]
        public void FindItineraryTest () {
            IList<IList<string>> itinerary = new List<IList<string>>(){
                new List<string>(){ "MUC", "LHR" },
                new List<string>(){ "JFK", "MUC" },
                new List<string>(){ "SFO", "SJC" },
                new List<string>(){ "LHR", "SFO" }
            };

            IList<string> expected = new List<string>() { "JFK", "MUC", "LHR", "SFO", "SJC" };

            Assert.IsTrue(expected.SequenceEqual(P332ReconstructItinerary.FindItinerary(itinerary)));

            itinerary = new List<IList<string>>(){
                new List<string>(){ "JFK","SFO" },
                new List<string>(){ "JFK","ATL" },
                new List<string>(){ "SFO","ATL" },
                new List<string>(){ "ATL", "JFK" },
                new List<string>(){ "ATL", "SFO" }
            };

            expected = new List<string>() { "JFK", "ATL", "JFK", "SFO", "ATL", "SFO" };

            Assert.IsTrue(expected.SequenceEqual(P332ReconstructItinerary.FindItinerary(itinerary)));
        }
    }
}
