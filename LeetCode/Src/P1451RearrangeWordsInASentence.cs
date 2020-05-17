using System.Linq;

namespace LeetCode.Src {
    class P1451RearrangeWordsInASentence {
        /// <summary>
        /// P1451 Rearrange Words in a Sentence. href = https://leetcode.com/problems/rearrange-words-in-a-sentence/
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ArrangeWords (string text) {
            string[] wordArray = text.Split(' ');
            wordArray = wordArray.OrderBy(x => x.Length).ToArray();

            // combine to form output string
            string firstWord = wordArray.First();
            string output = firstWord.First().ToString().ToUpper() + firstWord.Substring(1).ToLower();
            bool first = true;

            foreach (string word in wordArray) {
                if (!first) {
                    output += " " + word.ToLower();
                } else {
                    first = false;
                }
            }

            return output;
        }
    }
}
