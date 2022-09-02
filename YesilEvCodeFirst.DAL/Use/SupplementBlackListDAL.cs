using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs.SupplementBlackList;
using YesilEvCodeFirst.DTOs.UserBlackList;
using YesilEvCodeFirst.Mapping;

namespace YesilEvCodeFirst.DAL.Use
{
    public class SupplementBlackListDAL : EfRepoBase<YesilEvDbContext, SupplementBlackList>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        public bool AddSupplementBlackList(AddSupplementBlackListDTO dto)
        {
            try
            {
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var blacklist = context.BlackList.Where(u => u.UserID.Equals(dto.UserID)).FirstOrDefault();
                    if (blacklist == null)
                    {

                        context.BlackList.Add(new BlackList
                        {
                            UserID = dto.UserID
                        });
                        context.SaveChanges();
                        context.SupplementBlackList.Add(new SupplementBlackList
                        {
                            SupplementID = dto.SupplementID,
                            BlackListID = context.BlackList.LastOrDefault().BlackListID
                        });
                        context.SaveChanges();
                    }
                    else
                    {
                        context.SupplementBlackList.Add(new SupplementBlackList
                        {
                            SupplementID = dto.SupplementID,
                            BlackListID = blacklist.BlackListID
                        });
                        context.SaveChanges();
                    }
                }

                nLogger.Info("Madde Ve Kara liste tablosuna ekleme işlemi yapıldı.");

                return true;
            }
            catch (Exception ex)
            {

            }

            return false;
        }
        public bool DeleteSupplementBlackList(AddSupplementBlackListDTO dto)
        {
            try
            {
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var suppblacklist = context.SupplementBlackList.Where(u => u.BlackListID.Equals(dto.BlackListID) && u.SupplementID.Equals(dto.SupplementID)).FirstOrDefault();
                    if (suppblacklist != null)
                    {
                        suppblacklist.IsActive = false;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Silme işlemi yapılamadı.");
                    }

                }

                nLogger.Info("Kara liste tablosundan silme işlemi yapıldı.");

                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }
        public List<ListToSupplementBlackListDTO> GetDetailOfSupplementBlackList(int id)
        {
            int blacklistid = 0;
            using (YesilEvDbContext context = new YesilEvDbContext())
            {
                var blacklist = context.BlackList.Where(u=>u.UserID.Equals(id)).FirstOrDefault();
                if(blacklist != null)
                {
                    blacklistid = blacklist.BlackListID;
                }
                else
                {
                    throw new Exception("Kara liste bulunamadı.");
                }
                
            }
               
            var suppblacklist = GetByConditionWithInclude(u => u.BlackListID.Equals(blacklistid), "Supplement").ToList();
            if (suppblacklist != null)
            {
                return MappingProfile.SupplementBlackListToGetListToSupplementBlackListDTO(suppblacklist);
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
