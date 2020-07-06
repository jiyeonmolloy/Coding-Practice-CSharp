
namespace LeetCode.Src {
    /// <summary>
    /// P441 Arranging Coins
    ///  href = https://leetcode.com/problems/arranging-coins/
    /// </summary>
    class P441ArrangingCoins {
        public static int ArrangeCoins (int n) {
            if (n == 1) {
                return n;
            }

            int coins = n;
            int stairs = 0;
            for (int i = 1; i < n; i++) {
                coins -= i;
                if (coins < 0) {
                    return stairs;
                }
                if (coins == 0) {
                    return stairs + 1;
                }

                stairs++;
            }

            return stairs;
        }
    }
}
