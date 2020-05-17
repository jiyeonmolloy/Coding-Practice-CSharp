using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Src.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1452PeopleWhoseListOfFavoriteCompaniesIsNotASubsetOfAnotherListTest {
        [TestMethod]
        public void PeopleWhoseListOfFavoriteCompaniesIsNotASubsetOfAnotherList () {
            IList<IList<string>> favoriteCompanies = new List<IList<string>>(){
                new List<string>(){ "leetcode", "google", "facebook" },
                new List<string>(){ "google","microsoft" },
                new List<string>(){ "google","facebook" },
                new List<string>(){ "google" },
                new List<string>(){ "amazon" },
            };

            IList<int> expected = new List<int>() { 0, 1, 4 };
            Assert.IsTrue(expected.SequenceEqual(P1452PeopleWhoseListOfFavoriteCompaniesIsNotASubsetOfAnotherList.PeopleIndexes(favoriteCompanies)));

            favoriteCompanies = new List<IList<string>>(){
                new List<string>(){ "leetcode", "google", "facebook" },
                new List<string>(){ "leetcode","amazon" },
                new List<string>(){ "facebook","google" }
            };

            expected = new List<int>() { 0, 1 };
            Assert.IsTrue(expected.SequenceEqual(P1452PeopleWhoseListOfFavoriteCompaniesIsNotASubsetOfAnotherList.PeopleIndexes(favoriteCompanies)));

            favoriteCompanies = new List<IList<string>>(){
                new List<string>(){ "leetcode" },
                new List<string>(){ "google" },
                new List<string>(){ "facebook" },
                new List<string>(){ "amazon" }
            };

            expected = new List<int>() { 0, 1, 2, 3 };
            Assert.IsTrue(expected.SequenceEqual(P1452PeopleWhoseListOfFavoriteCompaniesIsNotASubsetOfAnotherList.PeopleIndexes(favoriteCompanies)));
        }
    }
}
