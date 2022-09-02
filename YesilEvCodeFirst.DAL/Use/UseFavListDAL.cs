using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs.UserBlackList;
using YesilEvCodeFirst.DTOs.UserFavList;
using YesilEvCodeFirst.Mapping;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseFavListDAL : EfRepoBase<YesilEvDbContext, FavList>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        public bool AddFavList(AddOrEditFavListDTO dto)
        {
            try
            {
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var favlist = context.FavList.Where(u => u.UserID.Equals(dto.UserID)).FirstOrDefault();
                    FavList addfavlist = MappingProfile.AddFavListDTOToFavList(dto);
                    context.FavList.Add(addfavlist);
                    context.SaveChanges();


                }

                nLogger.Info("Favori liste tablosuna ekleme işlemi yapıldı.");

                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
        public bool DeleteFavList(AddOrEditFavListDTO dto)
        {
            try
            {
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var favlist = context.FavList.Where(u => u.UserID.Equals(dto.UserID)).FirstOrDefault();
                    if (favlist != null)
                    {
                        favlist.IsActive = false;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Silme işlemi yapılamadı.");
                    }
                }

                nLogger.Info("Favori liste tablosundan silme işlemi yapıldı.");

                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
        public ListToFavListDTO GetDetailOfFavList(int id)
        {


            var favlist = GetByConditionWithInclude(u => u.UserID.Equals(id), "User").FirstOrDefault();
            if (favlist != null)
            {
                return MappingProfile.FavListToGetListToFavListDTO(favlist);
            }
            else
            {
                //  Eşleşmezse, yeni ürün ekleme sayfası gelecek ve doldurulması gereken formda barkod no hazır olarak gözükecek.
                throw new Exception("Kara Liste bulunamadı.");
            }

            nLogger.Info("Kara liste listeleme işlemi yapıldı.");

            return null;

        }
    }
}
