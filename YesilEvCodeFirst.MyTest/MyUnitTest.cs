using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.DAL;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs.Product;

namespace YesilEvCodeFirst.MyTest
{
    [TestClass]
    public class MyUnitTest
    {
        [TestMethod]
        public void AddProductTest()
        {
            UseProductDAL dal = new UseProductDAL();
            bool result = dal.AddProduct(new AddProductDTO()
            {
                ProductName = "TEST URUN 1",
                Barcode = Guid.NewGuid().ToString().Substring(0,7),
                CategoryID = 2,
                SupplierID = 2,
                ProductContent = "madde1, madde2, madde3, madde4, madde5, madde6",
                PictureBackPath = "backtest",
                PictureFronthPath = "fronttest"
            });

            if (!result)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void ListProductsTest()
        {
            UseProductDAL dal = new UseProductDAL();
            var result = dal.GetProductList();

            if(result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void GetProductDetailTest()
        {
            UseProductDAL dal = new UseProductDAL();
            var result = dal.GetProductDetailWithBarcode("014A76");

            if(result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void GetProductListForSearchbarTest()
        {
            UseProductDAL dal = new UseProductDAL();
            var result = dal.GetProductListForSearchbar("a");

            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }
    }
}
