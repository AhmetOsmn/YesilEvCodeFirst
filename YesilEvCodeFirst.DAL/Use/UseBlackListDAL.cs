using FluentValidation.Results;
using NLog;
using System;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.FluentValidator;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseBlackListDAL : EfRepoBase<YesilEvDbContext, BlackList>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        public bool AddBlackList(IDDTO dto)
        {
            AddBlackListValidator validator = new AddBlackListValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var blacklist = context.BlackList.Where(u => u.UserID.Equals(dto.ID)).FirstOrDefault();
                    if (blacklist == null)
                    {
                        BlackList addblacklist = MappingProfile.AddBlackListDTOToBlackList(dto);
                        context.BlackList.Add(addblacklist);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception(Messages.BlackListAlreadyExist);
                    }
                }

                nLogger.Info("Kara liste tablosuna ekleme işlemi yapıldı.");

                return true;
            }
            catch (FormatException fex)
            {
                nLogger.Error("System - {}", fex.Message);
                throw new FormatException(fex.Message);
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public bool DeleteBlackListWithUserID(IDDTO dto)
        {
            DeleteBlackListValidator validator = new DeleteBlackListValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var blacklist = context.BlackList.Where(u => u.UserID.Equals(dto.ID)).FirstOrDefault();
                    if (blacklist != null)
                    {
                        blacklist.IsActive = false;
                        blacklist.CreatedDate = DateTime.Now;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception(Messages.BlackListNotFound);
                    }
                }

                nLogger.Info("Kara liste tablosundan silme işlemi yapıldı.");

                return true;
            }
            catch (FormatException fex)
            {
                nLogger.Error("System - {}", fex.Message);
                throw new FormatException(fex.Message);
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public int GetBlackListIDWithUserID(IDDTO dto)
        {
            GetBlackListIDWithUserIDValidator validator = new GetBlackListIDWithUserIDValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                BlackList blackList = GetByCondition(u => u.UserID.Equals(dto.ID)).FirstOrDefault();
                if (blackList != null)
                {
                    nLogger.Info("{} ID'li kullanicinin kara liste ID'si getirildi.", dto.ID);
                    return blackList.BlackListID;
                }
                else
                {
                    throw new Exception(Messages.BlackListNotFound);
                }
            }
            catch (FormatException fex)
            {
                nLogger.Error("System - {}", fex.Message);
                throw new FormatException(fex.Message);
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
