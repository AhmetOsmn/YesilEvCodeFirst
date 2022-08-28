using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.DAL;
using YesilEvCodeFirst.DTOs.Product;

namespace YesilEvCodeFirst.MyTest
{
    [TestClass]
    public class MyUnitTest
    {
        [TestMethod]
        public void AddProductTest()
        {
            UseUrunDAL dal = new UseUrunDAL();
            bool result = dal.AddProduct(new AddProductDTO()
            {
                ProductContent = "TEST",
                BarcodeCode = Guid.NewGuid(),
                CategoryID = 2,
                // todo: maddeler'in int ile ID leri verilecek
                //Maddeler = new List<Supplement> { new Supplement { SupplementName = "Madde 1" }, new Supplement { SupplementName = "Madde 2" }},
                SupplierID = 3,
                ProductName = "TEST URUN 1",
               
            });

            if (!result)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void ListProductsTest()
        {
            UseUrunDAL dal = new UseUrunDAL();
            var result = dal.GetProductList();

            if(result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }
    }
}
