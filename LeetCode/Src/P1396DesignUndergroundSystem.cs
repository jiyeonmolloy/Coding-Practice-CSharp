using System;
using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P1396 Design Underground System
    /// href = https://leetcode.com/problems/design-underground-system/
    /// </summary> P1396DesignUndergroundSystem
    public class P1396DesignUndergroundSystem {
        private Dictionary<int, Tuple<string, double>> checkInTimes; // Key:id, station name (start) Value: check-in time
        private Dictionary<Tuple<string, string>, Tuple<double, double>> totalTimes; // Key: station name (start), station name (destination) Value: total time, freq

        public P1396DesignUndergroundSystem () {
            checkInTimes = new Dictionary<int, Tuple<string, double>>();
            totalTimes = new Dictionary<Tuple<string, string>, Tuple<double, double>>();
        }

        public void CheckIn (int id, string stationName, int t) {
            if (checkInTimes.ContainsKey(id)) {
                checkInTimes[id] = new Tuple<string, double>(stationName, t);
            } else {
                checkInTimes.Add(id, new Tuple<string, double>(stationName, t));
            }
        }

        public void CheckOut (int id, string stationName, int t) {
            // calculate travel time
            checkInTimes.TryGetValue(id, out var checkIn);
            double travelTime = t - checkIn.Item2;
            string startStation = checkIn.Item1;

            // calculate average times, if entry does not exist create a new one
            if (totalTimes.TryGetValue(new Tuple<string, string>(startStation, stationName), out var totalTime)) {
                totalTimes[new Tuple<string, string>(startStation, stationName)] = new Tuple<double, double>((totalTime.Item1 + travelTime), (totalTime.Item2 + 1));
            } else {
                totalTimes.Add(new Tuple<string, string>(startStation, stationName), new Tuple<double, double>(travelTime, 1));
            }
        }

        public double GetAverageTime (string startStation, string endStation) {
            if (totalTimes != null && totalTimes.TryGetValue(new Tuple<string, string>(startStation, endStation), out var totalTime)) {
                return Math.Round(totalTime.Item1 / totalTime.Item2, 5);
            }

            return 0;
        }
    }
}
