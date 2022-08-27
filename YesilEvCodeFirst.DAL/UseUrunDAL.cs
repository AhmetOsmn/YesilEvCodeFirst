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
        public bool UrunEkle(UrunEkleDTO dto)
        {
            JsonLogger<LogDTO> myLog = new JsonLogger<LogDTO>("MyLog");

            //validator

            try
            {

                UrunDAL dal = new UrunDAL();
                var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<UrunEkleDTO, Urun>()
                                                                    .ForMember(dest => dest.Maddeler, act => act.MapFrom(src => src.Maddeler))
                                                                    .AfterMap((urunDto, urun) =>
                                                                    {
                                                                        foreach (var item in urunDto.Maddeler)
                                                                        {
                                                                            urun.Maddeler = urunDto.Maddeler;
                                                                        }
                                                                    }));
                var mapper = new Mapper(mapperConfig);

                Urun eklenecekUrun = mapper.Map<Urun>(dto);
                dal.Add(eklenecekUrun);

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
                LogFunc(myLog, "", "Ahmet", ex.Message, "Urun", Islem.Error);
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
