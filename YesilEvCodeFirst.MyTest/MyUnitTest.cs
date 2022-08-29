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
        #region Login Testleri

        [TestMethod]
        public void UserLoginTest()
        {
            UseUserDAL dal = new UseUserDAL();
            var result = dal.UserLogin(new LoginDTO
            {
                Email = "ahmet@gmail.com",
                Password = "ahmet555"
            });

            if (result == false)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void AdminLoginTest()
        {
            UseAdminDAL dal = new UseAdminDAL();
            var result = dal.AdminLogin(new LoginDTO
            {
                Email = "ahmet@gmail.com",
                Password = "ahmet555"
            });

            if (result == false)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        #endregion

        #region Ekleme Testleri

        [TestMethod]
        public void AddProductTest()
        {
            UseProductDAL dal = new UseProductDAL();
            bool result = dal.AddProduct(new AddProductDTO()
            {
                ProductName = "TEST URUN 33",
                Barcode = Guid.NewGuid().ToString().Substring(0, 7),
                CategoryID = 1,
                SupplierID = 1,
                ProductContent = "madde1, madde2, madde3, madde4, madde33",
                PictureBackPath = "backtest2",
                PictureFronthPath = "fronttest2"
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
                LastName = "Kara",
                Email = "velikara@gmail.com",
                Password = "mert555",
                Phone = "5345898818",
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
            var result = dal.GetProductDetailWithBarcode("014B72");

            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void GetProductListForSearchbarTest()
        {
            UseProductDAL dal = new UseProductDAL();
            var result = dal.GetProductListForSearchbar("ülk");

            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        #endregion
    }
}
