using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
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
                nLogger.Error("System - {}", ex.Message);
            }
            return false;
        }
        public bool DeleteFavList(AddOrEditFavListDTO dto)
        {
            try
            {
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var favlist = context.FavList.Where(u => u.UserID.Equals(dto.UserID) && u.FavorID.Equals(dto.FavorID)).FirstOrDefault();
                    if (favlist != null)
                    {
                        favlist.IsActive = false;
                        favlist.CreatedDate = DateTime.Now;
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
                nLogger.Error("System - {}", ex.Message);
            }
            return false;
        }
        public bool UpdateFavList(AddOrEditFavListDTO dto)
        {
            try
            {
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var favlist = context.FavList.Where(u => u.UserID.Equals(dto.UserID) && u.FavorID.Equals(dto.FavorID)).FirstOrDefault();
                    if (favlist != null)
                    {
                        favlist.FavoriListName = dto.FavoriListName;
                        favlist.CreatedDate = DateTime.Now;
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
                nLogger.Error("System - {}", ex.Message);
            }
            return false;
        }
        public List<FavListDTO> GetFavListsWithUserID(int id)
        {
            try
            {
                var favlist = GetByCondition(u => u.UserID.Equals(id)).ToList();
                if (favlist != null)
                {
                    nLogger.Info("{} ID'li kullanicinin favori listeleri getirildi.", id);
                    return MappingProfile.FavListToFavListDTO(favlist);
                }
                else
                {
                    throw new Exception("Liste bulunamadı");
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }

            return null;
        }

        public int GetFavListIDWithFavListNameAndUserID(int id, string favlistName)
        {
            try
            {
                var favlist = GetByCondition(u => u.UserID.Equals(id) && u.FavoriListName.Equals(favlistName)).FirstOrDefault();
                if (favlist != null)
                {
                    nLogger.Info("{} ID'li kullanicinin {} listesinin ID'si getirildi.", id, favlistName);
                    return favlist.FavorID;
                }
                else
                {
                    throw new Exception("Liste bulunamadı");
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }

            return 0;
        }
    }
}
