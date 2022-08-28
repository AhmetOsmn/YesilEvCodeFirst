using AutoMapper;
using System.Collections.Generic;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.DTOs.Product;

namespace YesilEvCodeFirst.Mapping
{
    public static class MappingProfile
    {
        public static Product AddProductDTOToProduct(AddProductDTO dto)
        {
            //var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<UrunEkleDTO, Product>()
            //                                                             .ForMember(dest => dest.Maddeler, act => act.MapFrom(src => src.Maddeler))
            //                                                             .AfterMap((urunDto, urun) =>
            //                                                             {
            //                                                                 urun.Maddeler = urunDto.Maddeler;
            //                                                             }));
            //var mapper = new Mapper(mapperConfig);
            //return mapper.Map<Product>(dto);
            return new Product() { };
        }

        public static List<ListProductDTO> ProductListToProductListDTO(List<Product> productList)
        {
            //var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<Product, UrunListeleDTO>());

            //var mapper = new Mapper(mapperConfig);

            //var result = mapper.Map<List<UrunListeleDTO>>(urunList);
            //return result;
            return new List<ListProductDTO>();
        }



    }
}
