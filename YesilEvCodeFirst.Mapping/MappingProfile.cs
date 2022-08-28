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
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<AddProductDTO, Product>());
                                                                        
            var mapper = new Mapper(mapperConfig);
            return mapper.Map<Product>(dto);
        }

        public static List<ListProductDTO> ProductListToProductListDTO(List<Product> productList)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<Product, ListProductDTO>());

            var mapper = new Mapper(mapperConfig);

            var result = mapper.Map<List<ListProductDTO>>(productList);
            return result;
        }

        public static GetProductDetailDTO ProductToGetProductDetailDTO(Product product)
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, GetProductDetailDTO>()
                   .ForMember(dest => dest.SupplierName, opt => opt.MapFrom(src => src.Supplier.SupplierName))
                   .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName));
            });
            var mapper = new Mapper(mapperConfig);
            return mapper.Map<GetProductDetailDTO>(product);
        }
    }
}
