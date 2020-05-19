
namespace LeetCode.Src {
    class P567PermutationInString {
        public static bool CheckInclusion (string s1, string s2) {
            const int ALPHABET_MAX_COUNT = 26;
            int s1Len = s1.Length;
            int s2Len = s2.Length;

            if (s1Len > s2Len) {
                return false;
            }

            int[] s1AlphabetCount = new int[ALPHABET_MAX_COUNT];
            int[] s2AlphabetCount = new int[ALPHABET_MAX_COUNT];
            bool isAnagram;
            int anagramIndex;
            foreach (char c in s1) {
                s1AlphabetCount[c - 'a']++;
            }

            for (int i = 0; i < s2Len; i++) {
                s2AlphabetCount[s2[i] - 'a']++;

                if (i >= s1Len - 1) {
                    isAnagram = true;
                    for (int j = 0; j < ALPHABET_MAX_COUNT; j++) {
                        if (s1AlphabetCount[j] != s2AlphabetCount[j]) {
                            isAnagram = false;
                            break;
                        }
                    }

                    if (isAnagram) {
                        return isAnagram;
                    }

                    anagramIndex = i - s1Len + 1;
                    s2AlphabetCount[s2[anagramIndex] - 'a']--;
                }
            }

            return false;
        }
    }
}
