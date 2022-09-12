using FluentValidation.Results;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Supplement;
using YesilEvCodeFirst.DTOs.SupplementBlackList;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.FluentValidator;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseSupplementBlackListDAL : EfRepoBase<YesilEvDbContext, SupplementBlackList>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();
        UseSupplementDAL useSupplementDAL = new UseSupplementDAL();
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
                    var supplements = dto.SupplementContext.Split(',');
                    Array.ForEach(supplements, item =>
                    {
                        var result = context.Supplement.Where(x => x.SupplementName.Equals(item.Trim()) && x.IsActive).FirstOrDefault();
                        if (result == null)
                        {
                            AddSupplementDTO addSupplementDTO = new AddSupplementDTO()
                            {
                                SupplementName = item.Trim()
                            };
                            useSupplementDAL.AddSupplement(addSupplementDTO);
                            context.SaveChanges();
                            result = context.Supplement.Where(x => x.SupplementName.Equals(item.Trim()) && x.IsActive).FirstOrDefault();
                        }
                        var result1 = context.SupplementBlackList.Where(p => p.SupplementID == result.SupplementID && p.BlackListID == dto.BlackListID).FirstOrDefault();
                        if (result1 == null)
                        {
                            context.SupplementBlackList.Add(new SupplementBlackList()
                            {
                                BlackListID = dto.BlackListID,
                                SupplementID = result.SupplementID,
                            });
                            context.SaveChanges();
                        }
                        else if(!result1.IsActive)
                        {
                            result1.IsActive = true;
                            context.SaveChanges();
                        }                                               
                        
                    });
                    
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
                throw new Exception(ex.Message);
            }
        }
        public bool DeleteSupplementBlackList(DeleteSupplementBlackListDTO dto)
        {
            DeleteSupplementBlackListValidator validator = new DeleteSupplementBlackListValidator();
            ValidationResult validationResult = validator.Validate(dto);
            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }
                using (YesilEvDbContext context = new YesilEvDbContext())
                {

                    var suppblacklist = context.SupplementBlackList.Where(u => u.BlackListID == dto.BlackListID && u.SupplementID == dto.SupplementID && u.IsActive).FirstOrDefault();
                    if (suppblacklist != null)
                    {
                        suppblacklist.IsActive = false;
                        suppblacklist.CreatedDate = DateTime.Now;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception(ExceptionMessages.BlackListNotFound);
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
        public List<SupplementDTO> GetSupplementsWithBlackListID(IDDTO dto)
        {
            IDDTOValidator validator = new IDDTOValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if(!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                //List<SupplementBlackList> supplements = GetByConditionWithInclude(u => u.BlackListID == dto.ID && u.IsActive, "Supplement").ToList();
                List<SupplementBlackList> supplements;
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    supplements = context.SupplementBlackList.Include("Supplement").Where(u => u.BlackListID == dto.ID && u.IsActive).ToList();
                }
                if (supplements != null)
                {
                    nLogger.Info("{} ID'li kullanicinin kara listedeki maddeleri getirildi.", dto.ID);
                    return MappingProfile.SupplementBlackListListToSupplementDTOList(supplements);
                }
                else
                {
                    throw new Exception(ExceptionMessages.SupplementNotFoundForList);
                }
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
    }
}
