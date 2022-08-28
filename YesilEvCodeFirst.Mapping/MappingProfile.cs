using AutoMapper;
using System.Collections.Generic;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.DTOs.Urun;

namespace YesilEvCodeFirst.Mapping
{
    public static class MappingProfile
    {
        public static Urun UrunEkleDTOToUrun(UrunEkleDTO dto)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<UrunEkleDTO, Urun>()
                                                                         .ForMember(dest => dest.Maddeler, act => act.MapFrom(src => src.Maddeler))
                                                                         .AfterMap((urunDto, urun) =>
                                                                         {
                                                                             urun.Maddeler = urunDto.Maddeler;
                                                                         }));
            var mapper = new Mapper(mapperConfig);
            return mapper.Map<Urun>(dto);
        }

        public static List<UrunListeleDTO> UrunListTOUrunDTOList(List<Urun> urunList)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<List<Urun>, List<UrunListeleDTO>>());
            

            var mapper = new Mapper(mapperConfig);


            var result = mapper.Map<List<UrunListeleDTO>>(urunList);
            return result;
        }
    }
}
