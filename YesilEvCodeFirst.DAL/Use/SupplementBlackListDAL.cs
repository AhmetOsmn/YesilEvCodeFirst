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

                nLogger.Info("Kara liste tablosuna ekleme işlemi yapıldı.");

                return true;
            }
            catch (Exception ex)
            {

            }


            return false;
        }
    }
}
