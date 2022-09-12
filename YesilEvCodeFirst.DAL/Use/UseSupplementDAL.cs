using FluentValidation;
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
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.Supplement;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.FluentValidator;
using YesilEvCodeFirst.Validation.FluentValidator.Const;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseSupplementDAL : EfRepoBase<YesilEvDbContext, Supplement>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();
        public bool AddSupplement(AddSupplementDTO dto)
        {
            SupplementValidator validator = new SupplementValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                var tempSupplement = GetByCondition(supplement => supplement.SupplementName.ToLower() == dto.SupplementName.ToLower() && supplement.IsActive).FirstOrDefault();
                if (tempSupplement == null)
                {
                    Supplement eklenecekSupplement = MappingProfile.AddSupplementDTOToSupplement(dto);
                    Add(eklenecekSupplement);
                    MySaveChanges();
                    nLogger.Info("{} Supplement tablosuna eklendi", dto.SupplementName);
                }
                else
                {
                    throw new Exception(ExceptionMessages.SupplementAlreadyExist);
                }

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

        public List<ListSupplementDTO> GetSupplementList()
        {
            try
            {
                List<Supplement> supplements = null;

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    List<Supplement> result = context.Supplement.Where(x => x.IsActive).ToList();

                    supplements = result;
                }
                if (supplements == null)
                {
                    throw new Exception(ExceptionMessages.SupplementNotFoundForList);
                }
                else
                {
                    List<ListSupplementDTO> supplementDTOList = MappingProfile.SupplementListToSupplementListDTOList(supplements);
                    nLogger.Info("Supplement tablosu listelendi.");
                    return supplementDTOList;
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public List<Supplement> GetSupplementsForAdmin()
        {
            try
            {
                List<Supplement> supplements = GetAll();
                if (supplements == null)
                {
                    throw new Exception(ExceptionMessages.ProductListIsEmpty);
                }
                else
                {
                    List<ListSupplementDTO> supplementDTOList = MappingProfile.SupplementListToSupplementListDTOList(supplements);
                    nLogger.Info("Supplement tablosu listelendi.");
                    return supplements;
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }
        public List<Supplement> GetPSupplementListWithSearchbarForAdmin(string filter)
        {
            return GetByCondition(x => x.SupplementName.ToLower().Contains(filter.ToLower()));
        }

        public bool UpdateSupplementListWithSupplementName(AddSupplementDTO dto)
        {
            SupplementValidator validator = new SupplementValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var supplementlist = context.Supplement.Where(u => u.SupplementName.Equals(dto.SupplementName)).FirstOrDefault();
                    if (supplementlist != null)
                    {
                        supplementlist.SupplementName = dto.SupplementName;
                        supplementlist.RiskRatio = dto.Risk;
                        supplementlist.CreatedDate = DateTime.Now;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception(ExceptionMessages.BlackListNotFound);
                    }
                }

                nLogger.Info("Madde tablosunda güncelleme işlemi yapıldı.");

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
        public bool DeleteSupplement(AddSupplementDTO dto)
        {

            SupplementValidator validator = new SupplementValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                Supplement deletedSupplement = GetByCondition(p => p.SupplementName.Equals(dto.SupplementName.Trim()) && p.IsActive).FirstOrDefault();

                if (deletedSupplement != null)
                {
                    deletedSupplement.IsActive = false;

                    MySaveChanges();
                    using (YesilEvDbContext context = new YesilEvDbContext())
                    {
                        var Supplements = context.Supplement.Where(x => x.SupplementName == deletedSupplement.SupplementName).ToList();
                        Supplements.ForEach(x => x.IsActive = false);

                        context.SaveChanges();
                    }

                    nLogger.Info("{} barkodlu ürün silindi.", dto.SupplementName);
                    return true;
                }
                else
                {
                    throw new Exception(ExceptionMessages.ProductNotFound);
                }
            }
            catch (FormatException fex)
            {
                nLogger.Error("System - {}", fex.Message);
                throw new Exception(fex.Message);
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }
        public AddSupplementDTO GetProductDetailWithBarcode(AddSupplementDTO dto)
        {
            SupplementValidator validator = new SupplementValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    Supplement supplement = context.Supplement.Where(u => u.SupplementName == dto.SupplementName).FirstOrDefault();
                    if (supplement != null)
                    {
                        nLogger.Info("{} madde detaylari getirildi", supplement.SupplementName);
                        return MappingProfile.SupplementToGetListSupplementDTO(supplement);
                    }
                    else
                    {
                        throw new Exception(ExceptionMessages.ProductNotFound);
                    }
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
