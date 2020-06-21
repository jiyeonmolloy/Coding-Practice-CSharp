using System;
using System.Collections.Generic;

namespace LeetCode.Src {
    /// <summary>
    /// P1487 Making File Names Unique
    ///  href = https://leetcode.com/problems/making-file-names-unique/
    /// </summary>
    class P1487MakingFileNamesUnique {
        public static string[] GetFolderNames (string[] names) {
            Dictionary<string, int> nameDict = new Dictionary<string, int>();
            List<string> output = new List<String>();
            string newName = String.Empty;
            int freq;

            foreach (string name in names) {
                if (nameDict.ContainsKey(name)) {
                    freq = nameDict[name];
                    newName = name + "(" + freq + ")"; // can only happen once

                    while (nameDict.ContainsKey(newName)) {
                        freq++;
                        newName = name + "(" + freq + ")"; // keep same name
                    }

                    output.Add(newName);
                    nameDict[name]++;
                    nameDict.Add(newName, 1);
                } else {
                    output.Add(name);
                    nameDict.Add(name, 1);
                }
            }

            return output.ToArray();
        }
    }
}
