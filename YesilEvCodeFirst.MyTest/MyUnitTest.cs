using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.SearchHistory;
using YesilEvCodeFirst.DTOs.Supplement;
using YesilEvCodeFirst.DTOs.SupplementBlackList;
using YesilEvCodeFirst.DTOs.UserAdmin;
using YesilEvCodeFirst.DTOs.UserBlackList;
using YesilEvCodeFirst.DTOs.UserFavList;

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
                ProductName = "magnum beyaz çikolatalı",
                Barcode = Guid.NewGuid().ToString().Substring(0, 7),
                CategoryID = 2,
                SupplierID = 3,
                ProductContent = " Şeker, Maltodekstrin,Aroma Vericiler, süt tozu, amonyak, klor, florür",
                PictureBackPath = "backtest23",
                PictureFronthPath = "fronttest23",
                AddedBy = 5
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
            UseSupplementBlackListDAL dal = new UseSupplementBlackListDAL();
            bool result = dal.AddBlackList(new AddOrEditBlackListDTO()
            {
                UserID = 1,
            });

            if (!result)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }
        
        [TestMethod]
        public void AddFavListTest()
        {
            UseFavListDAL dal = new UseFavListDAL();
            bool result = dal.AddFavList(new AddOrEditFavListDTO()
            {
                UserID = 1,
            });

        [TestMethod]
        public void AddSearchHistoryTest()
        {
            UseSearchHistoryDAL dal = new UseSearchHistoryDAL();
            var result = dal.AddSearchHistory(new AddSearchHistoryDTO()
            {
                UserID = 1,
                ProductID = 2,
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
                PictureFronthPath = "fronttest2",
                AddedBy = 4
            });

            if (!result)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void DeleteBlackListTest()
        {

            UseSupplementBlackListDAL dal = new UseSupplementBlackListDAL();
            bool result = dal.DeleteBlackList(new AddOrEditBlackListDTO
            {
                UserID = 1,
            });

            if (!result)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void DeleteFavListTest()
        {

            UseFavListDAL dal = new UseFavListDAL();
            bool result = dal.DeleteFavList(new AddOrEditFavListDTO
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
        public void GetSearchHistoryListTest()
        {
            UseSearchHistoryDAL dal = new UseSearchHistoryDAL();
            var result = dal.GetSearchHistoryList();

            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void GetSearchHistoryListWithUserIDTest()
        {
            UseSearchHistoryDAL dal = new UseSearchHistoryDAL();
            var result = dal.GetSearchHistoryListWithUserID(1);

            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void GetProductListTest()
        {
            UseProductDAL dal = new UseProductDAL();
            var result = dal.GetProductList();

            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void GetSupplierListTest()
        {
            UseSupplierDAL dal = new UseSupplierDAL();
            var result = dal.GetSupplierList();

            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void GetCategoryListTest()
        {
            UseCategoryDAL dal = new UseCategoryDAL();
            var result = dal.GetCategoryList();

            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }
        [TestMethod]
        public void GetSupplementListTest()
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
        
        [TestMethod]
        public void GetSupplementBlackListDetailTest()
        {
            SupplementBlackListDAL dal = new SupplementBlackListDAL();

            var result = dal.GetDetailOfSupplementBlackList(1);


            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }
        
        [TestMethod]
        public void GetFavListDetailTest()
        {
            UseFavListDAL dal = new UseFavListDAL();

            var result = dal.GetDetailOfFavList(1);


            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        #endregion

        #region Silme Testleri

        [TestMethod]
        public void ClearSearchHistoryWithUserIDTest()
        {
            UseSearchHistoryDAL dal = new UseSearchHistoryDAL();
            var result = dal.ClearSearchHistoryWithUserID(1);

            if (result == false)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        #endregion


        #region BlackList Testleri

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
        }

        
        [TestMethod]
        public void Deneme1Test()
        {
            SupplementBlackListDAL dal = new SupplementBlackListDAL();
            var result = dal.DeleteSupplementBlackList(new AddSupplementBlackListDTO
            {

                BlackListID = 1,
                SupplementID = 2,

            });
           
            if (result == false)
            {
                throw new Exception("test sirasinda hata olustu");
            }

        }
        #endregion

        #region Rapor Testleri 

        [TestMethod]
        public void FavListProductCount()
        {
            UseRaporDAL dal = new UseRaporDAL();
            dal.GetUserProductListCount();
        }

        #endregion

    }
}
