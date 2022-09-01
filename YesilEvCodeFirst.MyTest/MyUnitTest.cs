using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.Supplement;
using YesilEvCodeFirst.DTOs.SupplementBlackList;
using YesilEvCodeFirst.DTOs.UserAdmin;
using YesilEvCodeFirst.DTOs.UserBlackList;

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
                Email = "veli@gmail.com",
                Password = "veli555"
            });

            if (result == null)
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
                ProductName = "bitter cikolata",
                Barcode = Guid.NewGuid().ToString().Substring(0, 7),
                CategoryID = 4,
                SupplierID = 2,
                ProductContent = " PEG-150 Distearate, Madde B, Karbonat, madde ar",
                PictureBackPath = "backtest23",
                PictureFronthPath = "fronttest23"
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
                FirstName = "Utku",
                LastName = "Hasa",
                Email = "utku@gmail.com",
                Password = "utku555",
                Phone = "11234425",
            });

            if (!result)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void AddSupplementTest()
        {
            UseSupplementDAL dal = new UseSupplementDAL();
            var result = dal.AddSupplement(new AddSupplementDTO
            {
                SupplementName = "test supplement 199"
            });

            if (!result)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void AddBlackListTest()
        {
            UseBlackListDAL dal = new UseBlackListDAL();
            bool result = dal.AddBlackList(new AddOrEditBlackListDTO()
            {
                UserID = 1,
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
                Barcode = "477a0e0",
                ProductName = "Test productsupplement 2",
                CategoryID = 2,
                SupplierID = 4,
                ProductContent = "Madde A, Madde B, Madde C, Madde D, Madde Sezgin, Madde Y",
                PictureBackPath = "backtest2",
                PictureFronthPath = "fronttest2"
            });

            if (!result)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void DeleteBlackListTest()
        {

            UseBlackListDAL dal = new UseBlackListDAL();
            bool result = dal.DeleteBlackList(new AddOrEditBlackListDTO
            {
                UserID = 1,
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
        public void SupplementListTest()
        {
            UseSupplementDAL dal = new UseSupplementDAL();
            var result = dal.GetSupplementList();

            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void GetProductDetailTest()
        {
            UseProductDAL dal = new UseProductDAL();
            var result = dal.GetProductDetailWithBarcode("477a0e0");

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

        [TestMethod]
        public void GetUserDetailTest()
        {
            UseUserDAL dal = new UseUserDAL();

            var result = dal.GetUserDetailWithEmail("utku@gmail.com");


            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        #endregion

        #region Silme Testleri


        #endregion

        #region Deneme

        [TestMethod]
        public void DenemeTest()
        {
            SupplementBlackListDAL dal = new SupplementBlackListDAL();

            var result = dal.AddSupplementBlackList(new AddSupplementBlackListDTO
            {
                UserID = 1,
                SupplementID = 1,

            });


            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }

            #endregion
        }
    }
}
