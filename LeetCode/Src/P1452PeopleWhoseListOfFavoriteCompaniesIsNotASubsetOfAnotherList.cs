using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Src.Common {
    class P1452PeopleWhoseListOfFavoriteCompaniesIsNotASubsetOfAnotherList {
        /// <summary>
        /// P1452 People Whose List of Favorite Companies Is Not a Subset of Another List. href = https://leetcode.com/problems/people-whose-list-of-favorite-companies-is-not-a-subset-of-another-list/
        /// </summary>
        /// <param name="favoriteCompanies"></param>
        /// <returns></returns>
        public static IList<int> PeopleIndexes (IList<IList<string>> favoriteCompanies) {
            List<HashSet<string>> companyHashSet = new List<HashSet<string>>();
            IList<int> output = new List<int>();

            foreach (var companyList in favoriteCompanies) {
                companyHashSet.Add(companyList.ToHashSet());
            }

            int size = companyHashSet.Count;
            bool isSubset;
            for (int i = 0; i < size; i++) {
                isSubset = false;
                for (int j = 0; j < size; j++) {
                    if (i != j && companyHashSet[i].IsSubsetOf(companyHashSet[j])) {
                        isSubset = true;
                        break;
                    }
                }

                if (!isSubset) {
                    output.Add(i);
                }
            }

            return output;
        }
    }
}
