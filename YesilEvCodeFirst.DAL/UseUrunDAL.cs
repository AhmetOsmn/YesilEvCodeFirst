using AutoMapper;
using System;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Concrete;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Urun;
using YesilEvCodeFirst.ExceptionHandling;
using YesilEvCodeFirst.Logs.Concrete;

namespace YesilEvCodeFirst.DAL
{
    public class UseUrunDAL : EfRepoBase<YesilEvDbContext, Urun>
    {
        private readonly IMapper _mapper;

        public UseUrunDAL(IMapper mapper)
        {
            _mapper = mapper;
        }

        public bool UrunEkle(UrunEkleDTO dto)
        {
            JsonLogger<LogDTO> myLog = new JsonLogger<LogDTO>("MyLog");

            //validator

            try
            {
                // validator.IsValid
                //if(!validator.IsValid)
                //{
                //    throw new ModelNotValidException(validator.ValidationMessages);
                //}

                UrunDAL dal = new UrunDAL();

                dal.Add(_mapper.Map<Urun>(dto));

                dal.MySaveChanges();

                LogFunc(myLog, "", "Ahmet", "Ekleme islemi basarili", "Urun", Islem.Info);

                return true;
            }
            catch (ModelNotValidException ex)
            {
                LogFunc(myLog, "", "Ahmet", ex.Message, "Urun", Islem.Error);
            }
            catch (Exception ex)
            {
                LogFunc(myLog,"","Ahmet",ex.Message,"Urun",Islem.Error);
            }
            return false;
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
