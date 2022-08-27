using AutoMapper;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.DTOs.Urun;

namespace YesilEvCodeFirst.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Urun, UrunEkleDTO>();
            CreateMap<UrunEkleDTO, Urun>();
        }
    }
}
