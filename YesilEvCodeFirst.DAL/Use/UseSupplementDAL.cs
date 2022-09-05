using FluentValidation.Results;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
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
                var tempSupplement = GetByCondition(supplement => supplement.SupplementName.ToLower() == dto.SupplementName.ToLower()).FirstOrDefault();
                if (tempSupplement == null)
                {
                    Supplement eklenecekSupplement = MappingProfile.AddSupplementDTOToSupplement(dto);
                    Add(eklenecekSupplement);
                    MySaveChanges();
                    nLogger.Info("{} Supplement tablosuna eklendi", dto.SupplementName);
                }
                else
                {
                    throw new Exception("Madde zaten mevcut.");
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
                    List<Supplement> result = context.Supplement.ToList();

                    supplements = result;
                }
                if (supplements == null)
                {
                    throw new Exception("Listelenecek supplement bulunamadı.");
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
    }
}
