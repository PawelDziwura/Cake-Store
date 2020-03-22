using System;
using System.Collections.Generic;
using System.Linq;
using Moq;
using CakeStore.Domain.Abstract;
using CakeStore.Domain.Entities;
using CakeStore.WebUI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CakeStore.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Paginate()
        {
            //przygotowanie
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new Product[]
            {
                new Product {ProductID = 1, Name = "P1"},
                new Product {ProductID = 2, Name = "P2"},
                new Product {ProductID = 3, Name = "P3"},
                new Product {ProductID = 4, Name = "P4"},
                new Product {ProductID = 5, Name = "P5"}
            });
            ProductController productController = new ProductController(mock.Object);
            productController.PageSize = 3;

            //działanie
            //IEnumerable<Product> result =
            //    (IEnumerable<Product>)productController.List(2).Model;
        }
    }
}
