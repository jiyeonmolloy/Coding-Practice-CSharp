using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P332 Reconstruct Itinerary
    ///  href = https://leetcode.com/problems/reconstruct-itinerary/
    /// </summary>
    class P332ReconstructItinerary {
        public static IList<string> FindItinerary (IList<IList<string>> tickets) {
            IList<string> itinerary = new List<string>();
            Dictionary<string, List<string>> ticketDict = new Dictionary<string, List<string>>();

            foreach (IList<string> ticket in tickets) {
                string from = ticket[0];
                string to = ticket[1];

                if (ticketDict.ContainsKey(from)) {
                    ticketDict[from].Add(to);
                } else {
                    ticketDict.Add(from, new List<string>());
                    ticketDict[from].Add(to);
                }
            }

            foreach (KeyValuePair<string, List<string>> item in ticketDict) {
                item.Value.Sort();
            }

            itinerary.Add("JFK");
            dfs(ticketDict, "JFK", tickets.Count, itinerary);
            return itinerary;
        }

        private static bool dfs (Dictionary<string, List<string>> ticket, string start, int trips, IList<string> itinerary) {
            if (trips == 0) {
                return true;
            }

            if (!ticket.ContainsKey(start)) {
                return false;
            }

            string finish;

            for (int i = 0; i < ticket[start].Count; i++) {
                finish = ticket[start][0];
                ticket[start].RemoveAt(0);
                itinerary.Add(finish);

                if (dfs(ticket, finish, trips - 1, itinerary)) {
                    return true;
                }

                ticket[start].Add(finish);
                itinerary.RemoveAt(itinerary.Count - 1);
            }

            return false;
        }
    }
}
