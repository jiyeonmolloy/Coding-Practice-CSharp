using System;

namespace LeetCode.Src {
    /// <summary>
    /// P165 Compare Version Numbers
    ///  href = https://leetcode.com/problems/compare-version-numbers/
    /// </summary>
    class P165CompareVersionNumbers {
        public static int CompareVersion (string version1, string version2) {
            // -1 means v2 is larger
            // 1 means v1 is larger
            // 1 means v1 and v2 are the same

            string[] v1Array = version1.Split('.');
            string[] v2Array = version2.Split('.');

            int index = 0;
            int total = Math.Max(v1Array.Length, v2Array.Length) - 1;

            int v1, v2;
            while (index <= total) {
                v1 = GetVersion(index, v1Array);
                v2 = GetVersion(index, v2Array);

                if (v1 > v2) {
                    return 1;
                } else if (v2 > v1) {
                    return -1;
                }

                index++;
            }

            return 0;
        }

        private static int GetVersion (int index, string[] versions) {
            if (index > versions.Length - 1) {
                return 0;
            }

            string version = versions[index].TrimStart(new Char[] { '0' });
            return version.Equals(String.Empty) ? 0 : int.Parse(version);
        }
    }
}
