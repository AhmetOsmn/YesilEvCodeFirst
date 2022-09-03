using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs.Rapor;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseRaporDAL
    {
        //User           Fav   Black
        //Mert Dalkıran   1      3
        //// Favori ürün sayısı
        // select u.FirstName , f.FavorID , Count(p.ProductName) from User u 
        // join FavList f on u.UserID = f.UserID 
        // join Product p on f.ProductID = p.ProductID
        // group by f.FavoriID
        //// KaraListe ürün sayısı
        // select u.FirstName , b.BlackListID , Count(p.ProductName) as UrunSayisi from [User] u
        // join BlackList b on u.CustomerID = b.UserID
        // join BlackListSupplement bm on b.BlackListID = bm.BlackListID
        // join ProductSupplement pm on bm.SupplementID = pm.SupplementID
        // join Product p on pm.ProductID = p.ProductID
        // group by b.BlackListID , u.FirstName
        public List<UserFavoriAndBlacklistProductCountDTO> GetUserProductListCount()
        {
            using (YesilEvDbContext context = new YesilEvDbContext())
            {
                var UserFavProduct = context.User.Join(context.FavList,
                                u => u.UserID,
                                f => f.UserID,
                                (x, y) => new
                                {
                                    user = x.UserID,
                                    User1 = x.FirstName + " " + x.LastName,
                                    FavorID = y.FavorID
                                }).Join(context.ProductFavList,
                                 onceki => onceki.FavorID,
                                 pf => pf.FavorID,
                                 (x1, y1) => new
                                 {
                                     user = x1.user,
                                     FavorID = x1.FavorID,
                                     Username = x1.User1,
                                     ProductID = y1.ProductID
                                 }).Join(context.Product,
                                   onceki1 => onceki1.ProductID,
                                   p => p.ProductID,
                                   (x2, y2) => new {
                                       User = x2.Username,
                                       FavoriID = x2.FavorID,
                                       ProductID = y2.ProductID,
                                       // BlacklistProductCount = 
                                   }).GroupBy(x => x.User).Select(grup => new UserFavoriAndBlacklistProductCountDTO
                                   {
                                       UserFirstAndLastName = grup.Key,
                                       FavoriCount = grup.Count(),
                                       BlackListCount = 0
                                   }).ToList();
                UserFavProduct.ForEach(x => {
                    var item = context.User.Join(context.BlackList, a => a.UserID, b => b.UserID, (ab, bc) => new
                    {
                        UserName = ab.FirstName + " " + ab.LastName,
                        BlackListID = bc.BlackListID,
                    }).Join(context.SupplementBlackList, b => b.BlackListID, sb => sb.BlackListID, (cd, de) => new {
                        UserName = cd.UserName,
                        SupplementID = de.SupplementID
                    }).Join(context.ProductSupplement, onceki => onceki.SupplementID, ps => ps.SupplementID, (ef, fg) => new {
                        UserName = ef.UserName,
                        ProductID = fg.ProductID
                    }).Join(context.Product, ps => ps.ProductID, p => p.ProductID, (gh, hi) => new {
                        UserName = gh.UserName,
                        ProductID = hi.ProductID
                    }).GroupBy(ij => ij.UserName).Select(grup => new {
                        UserName = grup.Key,
                        BlackListProductCount = grup.Count(),
                    }).Where(dc => dc.UserName == x.UserFirstAndLastName).FirstOrDefault();
                    if (item != null)
                    {
                        x.BlackListCount = item.BlackListProductCount;
                    }
                });
                return UserFavProduct;
            }
        }
    }
}
