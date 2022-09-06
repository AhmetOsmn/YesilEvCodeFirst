using FluentValidation.Results;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.Supplement;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.FluentValidator;

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

                //todo: tolower kullanilacak mi karar verilecek
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
                    throw new Exception(Messages.SupplementAlreadyExist);
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
                    throw new Exception(Messages.SupplementNotFoundForList);
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
                // todo: inclue yapilarak getirilecek
                List<Supplement> supplements = GetAll();
                if (supplements == null)
                {
                    throw new Exception(Messages.ProductListIsEmpty);
                }
                else
                {
                    List<ListSupplementDTO> productDTOList = MappingProfile.SupplementListToSupplementListDTOList(supplements);
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
    }
}
