using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P1583 Count Unhappy Friends
    ///  href = https://leetcode.com/problems/count-unhappy-friends/
    /// </summary>
    class P1583CountUnhappyFriends {
        public static int UnhappyFriends (int n, int[][] preferences, int[][] pairs) {
            // Store each pair in a pair dictionary to improve performance
            Dictionary<int, int> pairDictionary = new Dictionary<int, int>();
            foreach (int[] pair in pairs) {
                pairDictionary.Add(pair[0], pair[1]);
                pairDictionary.Add(pair[1], pair[0]);
            }

            // Store index (preference) of each friend in dictionary to improve performance
            Dictionary<int, int>[] prefDictionary = new Dictionary<int, int>[n];
            for (int i = 0; i < n; i++) {
                prefDictionary[i] = new Dictionary<int, int>();
                for (int j = 0; j < n - 1; j++) {
                    // Friend i's preferences
                    prefDictionary[i].Add(preferences[i][j], j);
                }
            }

            int unhappy = 0;
            int firstFriend, secondFriend;
            foreach (int[] pair in pairs) {
                firstFriend = pair[0];
                secondFriend = pair[1];
                if (IsUnhappy(firstFriend, secondFriend, preferences[firstFriend], pairDictionary, prefDictionary)) {
                    unhappy++;
                }

                if (IsUnhappy(secondFriend, firstFriend, preferences[secondFriend], pairDictionary, prefDictionary)) {
                    unhappy++;
                }
            }

            return unhappy;
        }

        private static bool IsUnhappy (int firstFriend, int secondFriend, int[] preference,
            Dictionary<int, int> pairDictionary,
            Dictionary<int, int>[] preferenceDictionary) {

            int friend, pair;
            int friendPreference, pairPreference;
            for (int i = 0; i < preference.Length; i++) {
                friend = preference[i];
                if (friend.Equals(secondFriend)) {
                    break;
                }

                friendPreference = preferenceDictionary[friend][firstFriend];

                pair = pairDictionary[friend];
                pairPreference = preferenceDictionary[friend][pair];

                if (friendPreference < pairPreference) {
                    return true;
                }
            }

            return false;
        }
    }
}
