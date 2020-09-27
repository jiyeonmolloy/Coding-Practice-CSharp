
namespace LeetCode.Src {
    /// <summary>
    /// P1598 Crawler Log Folder
    ///  href = https://leetcode.com/problems/crawler-log-folder/
    /// </summary>
    class P1598CrawlerLogFolder {
        public static int MinOperations (string[] logs) {
            int operations = 0;
            foreach (string log in logs) {
                if (log.Equals("./")) {
                    continue;
                }

                if (log.Equals("../")) {
                    if (operations > 0) {
                        operations -= 1;
                    }
                } else {
                    operations++;
                }
            }

            return operations;
        }
    }
}
