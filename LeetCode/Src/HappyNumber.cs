
namespace LeetCode.Src {
    static class HappyNumber {

        internal static bool IsHappy (int n) {
            int fast = n;
            int slow = n;

            do {
                // Perform cycle detection 
                fast = ComputeSum(ComputeSum(fast));
                slow = ComputeSum(slow);
            } while (fast != slow);

            return fast == 1;
        }

        internal static int ComputeSum (int n) {
            int reminder = 0;
            int sum = 0;

            while (n > 0) {
                reminder = n % 10;
                sum += reminder * reminder;
                n /= 10;
            }

            return sum;
        }
    }
}
