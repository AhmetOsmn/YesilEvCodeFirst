using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.UserAdmin;

namespace YesilEvCodeFirst.MyTest
{
    [TestClass]
    public class MyUnitTest
    {
        [TestMethod]
        public void LoginTest()
        {
            UseUserDAL dal = new UseUserDAL();
            var result = dal.Login(new LoginDTO
            {
                Email = "ahmet@gmail.com",
                Password = "ahmet555"
            });

            if (result == false)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        #region Ekleme Testleri

        [TestMethod]
        public void AddProductTest()
        {
            UseProductDAL dal = new UseProductDAL();
            bool result = dal.AddProduct(new AddProductDTO()
            {
                ProductName = "TEST URUN 1",
                Barcode = Guid.NewGuid().ToString().Substring(0, 7),
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
        public void AddUserTest()
        {
            UseUserDAL dal = new UseUserDAL();
            bool result = dal.AddUser(new AddUserDTO()
            {
                FirstName = "Veli",
                LastName = "Canlı",
                Email = "veli@gmail.com",
                UserName = "userveli",
                Password = "veli555",
                Phone = "5345898818",
                RolID = 2
            });

            if (!result)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        #endregion

        #region Guncelleme Testleri

        [TestMethod]
        public void UpdateProductTest()
        {
            UseProductDAL dal = new UseProductDAL();
            bool result = dal.UpdateProduct(new UpdateProductDTO()
            {
                Barcode = "e58a083",
                ProductName = "TEST URUN 1",
                CategoryID = 2,
                SupplierID = 1,
                ProductContent = "madde1, madde2, madde3, madde4, madde5, madde6",
                PictureBackPath = "backtest",
                PictureFronthPath = "fronttest"
            });

            if (!result)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        #endregion

        #region Listeleme Testleri

        [TestMethod]
        public void ProductListTest()
        {
            UseProductDAL dal = new UseProductDAL();
            var result = dal.GetProductList();

            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void SupplierListTest()
        {
            UseSupplierDAL dal = new UseSupplierDAL();
            var result = dal.GetSupplierList();

            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void CategoryListTest()
        {
            UseCategoryDAL dal = new UseCategoryDAL();
            var result = dal.GetCategoryList();

            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void GetProductDetailTest()
        {
            UseProductDAL dal = new UseProductDAL();
            var result = dal.GetProductDetailWithBarcode("014A76");

            if (result == null)
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

        #endregion
    }
}
