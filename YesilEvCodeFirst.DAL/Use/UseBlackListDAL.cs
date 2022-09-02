using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs.UserBlackList;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.Logs.Concrete;
using YesilEvCodeFirst.Mapping;
using NLog;
using YesilEvCodeFirst.DTOs.Category;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseSupplementBlackListDAL : EfRepoBase<YesilEvDbContext, BlackList>
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

            }
            return false;
        }

    }
}
