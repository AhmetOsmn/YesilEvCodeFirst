using AutoMapper;
using System.Collections.Generic;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.DTOs.Category;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.Supplier;
using YesilEvCodeFirst.DTOs.UserAdmin;

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

            return mapper.Map<List<ListProductDTO>>(productList);
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

        public static List<SupplierDTO> SupplierListToSupplierDTOList(List<Supplier> supplierList)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<Supplier, SupplierDTO>());

            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<SupplierDTO>>(supplierList);
        }

        public static List<CategoryDTO> CategoryListToCategoryDTOList(List<Category> categoryList)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryDTO>());

            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<CategoryDTO>>(categoryList);
        }

        public static User AddUserDTOtoUser(AddUserDTO dt)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<AddUserDTO, User>());

            var mapper = new Mapper(mapperConfig);
            return mapper.Map<User>(dt);
        }
    }
}
