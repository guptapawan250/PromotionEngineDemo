using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemStatementForPromotionEngine;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class PromotionTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            IProductDetails prodDetail = new ProductDetails();
            ProductManager prodMgr = new ProductManager(prodDetail);
            List<Product> products = prodMgr.GetProductList();
            
            Assert.IsNotNull(products);

        }

        [TestMethod]
        public void GetTotalAmountTest()
        {
            IProductDetails prodDetail = new ProductDetails();
            ProductManager prodMgr = new ProductManager(prodDetail);
            List<Product> prodLst = new List<Product>()
            {
                new Product("A", 5),
                new Product("B", 5),
                new Product("C", 1),
                new Product("D", 0)
            };
           var result = prodMgr.GetTotalPrice(prodLst);
           Assert.IsNotNull(result);
        }
    }
}
