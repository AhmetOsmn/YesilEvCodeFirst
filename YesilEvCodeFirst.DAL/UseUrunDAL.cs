using AutoMapper;
using System;
using System.Collections.Generic;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Concrete;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Urun;
using YesilEvCodeFirst.ExceptionHandling;
using YesilEvCodeFirst.Logs.Concrete;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.Urun;

namespace YesilEvCodeFirst.DAL
{
    public class UseUrunDAL : EfRepoBase<YesilEvDbContext, Urun>
    {
        JsonLogger<LogDTO> myLog = new JsonLogger<LogDTO>("MyLog.txt");
        public bool UrunEkle(UrunEkleDTO dto)
        {
            UrunEkleValidator validator = new UrunEkleValidator(dto);

            try
            {
                if (!validator.IsValid)
                {
                    throw new ModelNotValidException(validator.ValidationMessages);
                }

                UrunDAL dal = new UrunDAL();

                Urun eklenecekUrun = MappingProfile.UrunEkleDTOToUrun(dto);
                dal.Add(eklenecekUrun);

                dal.MySaveChanges();

                LogFunc(myLog, "", "Osman", "Ekleme islemi basarili", "Urun", Islem.Info);

                return true;
            }
            catch (ModelNotValidException ex)
            {
                LogFunc(myLog, "", "Ahmet", ex.Message, "Urun", Islem.Error);
            }
            catch (Exception ex)
            {
                LogFunc(myLog, "", "Ahmet", ex.Message, "Urun", Islem.Error);
            }
            return false;
        }

        public List<UrunListeleDTO> UrunleriListele()
        {
            try
            {
                UrunDAL dal = new UrunDAL();

                var urunler = dal.GetAll();
                List<UrunListeleDTO> urunList = MappingProfile.UrunListTOUrunDTOList(urunler);
                LogFunc(myLog, "", "Ahmet Osman", "Listeleme islemi basarili", "Urun", Islem.Info);
                return urunList;
            }
            catch (Exception ex)
            {

                LogFunc(myLog, "", "Ahmet Osman", ex.Message, "Urun", Islem.Error);
            }

            return null;
        }
        private void LogFunc(JsonLogger<LogDTO> myLog, string dataID, string kisi, string not, string tablo, Islem islem)
        {
            myLog.Log(new LogDTO()
            {
                DataID = dataID,
                Islem = islem,
                Kisi = kisi,
                Not = not,
                Tablo = tablo,
                IslemTarihi = DateTime.Now
            });
        }
    }
}
