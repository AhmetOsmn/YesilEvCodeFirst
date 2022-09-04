using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using YesilEvCodeFirst.DAL.Use;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.ProductFavList;
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

        [TestMethod]
        public void AddFavListTest()
        {
            UseFavListDAL dal = new UseFavListDAL();
            bool result = dal.AddFavList(new AddFavListDTO()
            {
                UserID = 1,
                FavoriListName = "Sarp Sinema",
            });
            if (!result)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }
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
        
        [TestMethod]
        public void DeleteProFavListTest()
        {

            UseProductFavListDAL dal = new UseProductFavListDAL();
            bool result = dal.DeleteProductFavList(new AddProductFavListDTO
            {
                ProductID = 1,
                FavorID = 1,
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
            bool result = dal.DeleteFavList(new EditFavListDTO
            {
                UserID = 1,
                FavorID = 2,
            });

            if (!result)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void UpdateFavListTest()
        {

            UseFavListDAL dal = new UseFavListDAL();
            bool result = dal.UpdateFavList(new EditFavListDTO
            {
                UserID = 1,
                FavorID = 1,
                FavoriListName = "Deneme",
            });

            if (!result)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }



        #endregion

        #region Listeleme Testleri

        [TestMethod]
        public void GetSupplementsWithProductIDTest()
        {
            UseProductSupplementDAL dal = new UseProductSupplementDAL();

            var result = dal.GetSupplementsWithProductID(2);

            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void GetSupplementsWithBlackListIDTest()
        {
            UseSupplementBlackListDAL dal = new UseSupplementBlackListDAL();

            var result = dal.GetSupplementsWithBlackListID(1);

            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void GetBlackListWithUserIDTest()
        {
            UseBlackListDAL dal = new UseBlackListDAL();

            var result = dal.GetBlackListIDWithUserID(1);

            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

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
            UseSupplementBlackListDAL dal = new UseSupplementBlackListDAL();

            bool result = false;


            if (result == false)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void GetFavListsWithUserIDTest()
        {
            UseFavListDAL dal = new UseFavListDAL();

            var result = dal.GetFavListsWithUserID(1);

            if (result == null)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }

        [TestMethod]
        public void GetProductsWithFavListIDTest()
        {
            UseProductFavListDAL dal = new UseProductFavListDAL();

            var result = dal.GetProductsWithFavListID(3);

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
            UseSupplementBlackListDAL dal = new UseSupplementBlackListDAL();
            var result = dal.AddSupplementBlackList(new AddSupplementBlackListDTO
            {

                UserID = 1,
                SupplementID = 1,

            });
            if (!result)
            {
                throw new Exception("test sirasinda hata olustu");
            }
        }


        [TestMethod]
        public void Deneme1Test()
        {
            UseSupplementBlackListDAL dal = new UseSupplementBlackListDAL();
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

        #region FavTestleri

        [TestMethod]
        public void Deneme2Test()
        {
            UseProductFavListDAL dal = new UseProductFavListDAL();
            var result = dal.AddProductToFavList(new AddProductFavListDTO
            {

                FavorID = 2,
                ProductID = 1,

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

