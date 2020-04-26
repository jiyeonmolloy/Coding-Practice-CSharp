using System;
using System.Collections.Generic;
using System.Linq;
using CodingPractice.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPractice.Test {
    [TestClass]
    public class ProductOfArrayTest {
        [TestMethod]
        public void ProductExceptSelf () {
            int[] expected = { 24, 12, 8, 6 };
            int[] numbers = { 1, 2, 3, 4 };

            ProductOfArray productOfArray = new ProductOfArray();
            CollectionAssert.AreEqual(expected, productOfArray.ProductExceptSelf(numbers));
        }
    }
}
