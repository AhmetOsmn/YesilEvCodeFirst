using NLog;
using System;
using System.Linq;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs.UserBlackList;
using YesilEvCodeFirst.Mapping;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseBlackListDAL : EfRepoBase<YesilEvDbContext, BlackList>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        public bool AddBlackList(AddOrEditBlackListDTO dto)
        {
            try
            {
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var blacklist = context.BlackList.Where(u => u.UserID.Equals(dto.UserID)).FirstOrDefault();
                    if (blacklist == null)
                    {
                        BlackList addblacklist = MappingProfile.AddBlackListDTOToBlackList(dto);
                        context.BlackList.Add(addblacklist);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Kara liste zaten mevcut.");
                    }
                }

                nLogger.Info("Kara liste tablosuna ekleme işlemi yapıldı.");

                return true;
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }
            return false;
        }

        public bool DeleteBlackList(AddOrEditBlackListDTO dto)
        {
            try
            {
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var blacklist = context.BlackList.Where(u => u.UserID.Equals(dto.UserID)).FirstOrDefault();
                    if (blacklist != null)
                    {
                        blacklist.IsActive = false;
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
                nLogger.Error("System - {}", ex.Message);
            }
            return false;
        }

        public int GetBlackListIDWithUserID(int id)
        {
            try
            {
                BlackList blackList = GetByCondition(u => u.UserID.Equals(id)).FirstOrDefault();
                if (blackList != null)
                {
                    nLogger.Info("{} ID'li kullanicinin kara liste ID'si getirildi.", id);
                    return blackList.BlackListID;
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
