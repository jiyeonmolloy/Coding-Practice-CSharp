
namespace LeetCode.Src {
    class P997FindTheTownJudge {
        /// <summary>
        /// P997 Find The Town Judge. href = 
        /// </summary>
        /// <param name="N"></param>
        /// <param name="trust"></param>
        /// <returns></returns>
        public static int FindJudge (int N, int[][] trust) {
            int[] trustArray = new int[N + 1]; // Store the person's relationship (Inbound - Outbound)
            const int MAIN = 0;
            const int TARGET = 1;

            foreach (int[] singleTrust in trust) {
                trustArray[singleTrust[MAIN]]--; // Outbount
                trustArray[singleTrust[TARGET]]++; // Inbound
            }

            for (int i = 1; i <= N; ++i) {
                // Mafia satisfies the condition: (Inbound - Outbound) =  N - 1
                if (trustArray[i] == N - 1) {
                    return i;
                }
            }

            return -1;
        }
    }
}
