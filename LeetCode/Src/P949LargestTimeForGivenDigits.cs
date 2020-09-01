using LeetCode.Src.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    ///  P949 Largest Time For Given Digits
    ///  href = https://leetcode.com/problems/largest-time-for-given-digits/
    /// </summary>
    class P949LargestTimeForGivenDigits : Permutator {
        public static string LargestTimeFromDigits (int[] A) {
            // Smallest: 00:00, largest: 23:59
            IEnumerable<IEnumerable<int>> timePermutations = Permutate(A);

            int maxMins = -1;
            List<int> timesList;
            int hour1, hour2, min1, min2;
            int totalHours, totalMins;
            foreach (IEnumerable<int> times in timePermutations) {
                timesList = times.ToList();
                hour1 = timesList[0];
                hour2 = timesList[1];
                min1 = timesList[2];
                min2 = timesList[3];

                totalHours = hour1 * 10 + hour2;
                totalMins = min1 * 10 + min2;

                if (totalHours < 24 && min1 < 6) {
                    // Convert current time to minutes, and get the higher time
                    maxMins = Math.Max(maxMins, totalHours * 60 + totalMins);
                }
            }

            if (maxMins == -1) {
                return String.Empty;
            }

            totalHours = maxMins / 60;
            totalMins = maxMins % 60;

            hour1 = totalHours / 10;
            hour2 = totalHours % 10;
            min1 = totalMins / 10;
            min2 = totalMins % 10;

            return $"{hour1}{hour2}:{min1}{min2}";
        }
    }
}
