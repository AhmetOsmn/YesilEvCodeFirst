using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs.Supplement;
using YesilEvCodeFirst.ExceptionHandling;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.Supplement;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseSupplementDAL : EfRepoBase<YesilEvDbContext, Supplement>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();
        public bool AddSupplement(AddSupplementDTO dto)
        {
            AddSupplementValidator validator = new AddSupplementValidator(dto);

            try
            {
                if (!validator.IsValid)
                {
                    throw new ModelNotValidException(validator.ValidationMessages);
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
                    throw new Exception("Madde zaten mevcut");
                }

                return true;
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }

            return false;

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
                if(supplements == null)
                {
                    throw new Exception("Listelenecek supplement bulunamadi");
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
            }

            return null;
        }
    }
}
