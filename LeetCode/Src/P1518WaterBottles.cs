
namespace LeetCode.Src {
    /// <summary>
    /// P1518 Water Bottles
    ///  href = https://leetcode.com/problems/water-bottles/
    /// </summary>
    class P1518WaterBottles {
        public static int NumWaterBottles (int numBottles, int numExchange) {
            int remainingBottles = numBottles;
            int newBottles = 0;

            int countBottles = numBottles;

            while (numBottles >= numExchange) {
                newBottles = numBottles / numExchange;
                countBottles += newBottles;

                remainingBottles = numBottles % numExchange;
                numBottles = newBottles + remainingBottles;
            }

            return countBottles;
        }
    }
}
