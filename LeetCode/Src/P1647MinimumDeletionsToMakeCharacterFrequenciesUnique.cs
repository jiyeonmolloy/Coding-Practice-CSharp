using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src {
    /// <summary>
    /// P1647 Minimum Deletions To Make Character Frequencies Unique
    ///  href = https://leetcode.com/problems/minimum-deletions-to-make-character-frequencies-unique/
    /// </summary>
    public class CustomNode {
        public int Freq;
        public int Value;

        public CustomNode (int value, int freq) {
            Value = value;
            Freq = freq;
        }
    }

    class P1647MinimumDeletionsToMakeCharacterFrequenciesUnique {
        public static int MinDeletions (string s) {
            int[] frequency = new int[26];

            foreach (char character in s) {
                frequency[character - 'a']++;
            }

            SortedDictionary<int, HashSet<int>> setMultiMap = new SortedDictionary<int, HashSet<int>>(); // hashset

            int freq = 0;
            int target;
            for (int i = 0; i < frequency.Length; i++) {
                freq = frequency[i];
                if (freq == 0) {
                    continue;
                }
                target = i;
                if (setMultiMap.ContainsKey(freq)) {
                    setMultiMap[freq].Add(target);
                } else {
                    setMultiMap[freq] = new HashSet<int>();
                    setMultiMap[freq].Add(target);
                }
            }

            Queue<CustomNode> queue = new Queue<CustomNode>();
            int currentCharacter;
            int moveFreq = 0;
            for (int i = setMultiMap.Keys.Max(); i > 0; i--) {
                if (setMultiMap.ContainsKey(i) && setMultiMap[i].Count > 1) {
                    bool start = true;
                    foreach (int charNumber in setMultiMap[i]) {
                        if (start) {
                            start = false;
                            continue;
                        }
                        currentCharacter = charNumber;
                        queue.Enqueue(new CustomNode(currentCharacter, i));
                    }
                    continue;
                }

                // De queue one node
                if (queue.Count > 0 && (!setMultiMap.ContainsKey(i) || setMultiMap.ContainsKey(i) && setMultiMap[i].Count != 1)) {
                    CustomNode node = queue.Dequeue();
                    moveFreq += node.Freq - i;
                }
            }

            while (queue.Count > 0) {
                CustomNode unload = queue.Dequeue();
                moveFreq += unload.Freq;
            }

            return moveFreq;
        }
    }
}
