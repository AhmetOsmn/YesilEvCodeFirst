using System;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Supplement;
using YesilEvCodeFirst.ExceptionHandling;
using YesilEvCodeFirst.Logs.Concrete;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.Supplement;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseSupplementDAL : EfRepoBase<YesilEvDbContext, Supplement>
    {
        JsonLogger<LogDTO> myLog = new JsonLogger<LogDTO>("MyLog.txt");
        public bool AddSupplement(AddSupplementDTO dto)
        {
            AddSupplementValidator validator = new AddSupplementValidator(dto);

            try
            {
                if(!validator.IsValid)
                {
                    throw new ModelNotValidException(validator.ValidationMessages);
                }

                //todo: tolower kullanilacak mi karar verilecek
                var tempSupplement = GetByCondition(supplement => supplement.SupplementName.ToLower() == dto.SupplementName.ToLower()).FirstOrDefault();
                if(tempSupplement == null)
                {
                    Supplement eklenecekSupplement = MappingProfile.AddSupplementDTOToSupplement(dto);
                    Add(eklenecekSupplement);
                    MySaveChanges();
                    LogExtension.LogFunc(myLog, "", "Ahmet", "Ekleme islemi basarili", "Supplement", Islem.Info);
                }
                else
                {
                    throw new Exception("Madde zaten mevcut");
                }

                return true;
            }
            catch (Exception ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Supplement", Islem.Error);
            }
            
            return false;

        }
    }
}
