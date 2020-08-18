using System;

namespace LeetCode.Src {
    /// <summary>
    /// P1103 Distribute Candies To People
    ///  href = https://leetcode.com/problems/distribute-candies-to-people/
    /// </summary>
    class P1103DistributeCandiesToPeople {
        public static int[] DistributeCandies (int candies, int num_people) {
            int[] people = new int[num_people];
            int currentCandy = 1;
            int currentPerson = 0;

            while (candies >= 0) {

                people[currentPerson] += Math.Min(currentCandy, candies);
                candies -= currentCandy;
                currentCandy++;
                currentPerson = (currentPerson + 1) % num_people;
            }

            return people;
        }
    }
}
