using FluentValidation.Results;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs.Supplement;
using YesilEvCodeFirst.DTOs.SupplementBlackList;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.FluentValidator;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseSupplementBlackListDAL : EfRepoBase<YesilEvDbContext, SupplementBlackList>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        public bool AddSupplementBlackList(AddSupplementBlackListDTO dto)
        {
            SupplementBlackListValidator validator = new SupplementBlackListValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

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
            catch(FormatException fex)
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
        public bool DeleteSupplementBlackList(AddSupplementBlackListDTO dto)
        {
            SupplementBlackListValidator validator = new SupplementBlackListValidator();
            ValidationResult validationResult = validator.Validate(dto);
            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var suppblacklist = context.SupplementBlackList.Where(u => u.BlackListID.Equals(dto.BlackListID) && u.SupplementID.Equals(dto.SupplementID)).FirstOrDefault();
                    if (suppblacklist != null)
                    {
                        suppblacklist.IsActive = false;
                        suppblacklist.CreatedDate = DateTime.Now;
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
            catch(FormatException fex)
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
        public List<SupplementDTO> GetSupplementsWithBlackListID(int id)
        {
            try
            {
                List<SupplementBlackList> supplements = GetByConditionWithInclude(u => u.BlackListID.Equals(id), "Supplement").ToList();

                if (supplements != null)
                {
                    nLogger.Info("{} ID'li kullanicinin kara listedeki maddeleri getirildi.", id);
                    return MappingProfile.SupplementBlackListListToSupplementDTOList(supplements);
                    throw new Exception("{} ID'li kullanicinin kara listedeki maddeleri getirildi.");
                }
                else
                {
                    throw new Exception("Liste bulunamadı");
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
