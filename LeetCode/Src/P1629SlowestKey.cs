
namespace LeetCode.Src {
    /// <summary>
    /// P1629 Slowest Key
    ///  href = https://leetcode.com/problems/slowest-key/
    class P1629SlowestKey {
        public static char SlowestKey (int[] releaseTimes, string keysPressed) {
            int max = releaseTimes[0];
            char key = keysPressed[0];

            int length;
            for (int i = 1; i < releaseTimes.Length; i++) {
                length = releaseTimes[i] - releaseTimes[i - 1];
                if (length > max || (length == max && (keysPressed[i] - 'a') > (key - 'a'))) {
                    max = length;
                    key = keysPressed[i];
                }
            }

            return key;
        }
    }
}
