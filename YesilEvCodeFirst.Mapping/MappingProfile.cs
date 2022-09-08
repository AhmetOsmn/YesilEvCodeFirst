using AutoMapper;
using System.Collections.Generic;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Category;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.SearchHistory;
using YesilEvCodeFirst.DTOs.Supplement;
using YesilEvCodeFirst.DTOs.SupplementBlackList;
using YesilEvCodeFirst.DTOs.Supplier;
using YesilEvCodeFirst.DTOs.UserAdmin;
using YesilEvCodeFirst.DTOs.UserBlackList;
using YesilEvCodeFirst.DTOs.UserFavList;

namespace YesilEvCodeFirst.Mapping
{
    public static class MappingProfile
    {
        #region Product

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

        public static List<ProductListForAdminDTO> ProductListToProductListForAdminDTOList(List<Product> products)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductListForAdminDTO>()
                                                        .ForMember(dest => dest.AdderName, opt => opt.MapFrom(src => src.Adder.FirstName + " " + src.Adder.LastName))
                                                        .ForMember(dest => dest.ApproverName, opt => opt.MapFrom(src => src.Approver.FirstName + " " + src.Approver.LastName))
                                                        .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName))
                                                        .ForMember(dest => dest.SupplierName, opt => opt.MapFrom(src => src.Supplier.SupplierName)));

            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<ProductListForAdminDTO>>(products);
        }

        #endregion

        #region Supplement

        public static SupplementBlackList AddSupplementBlackListDTOToSupplementBlackList(AddSupplementBlackListDTO dto)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<AddSupplementBlackListDTO, SupplementBlackList>());

            var mapper = new Mapper(mapperConfig);
            return mapper.Map<SupplementBlackList>(dto);
        }

        public static List<DTOs.Supplement.ListSupplementDTO> SupplementListToSupplementListDTOList(List<Supplement> supplementList)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<Supplement, DTOs.Supplement.ListSupplementDTO>());

            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<DTOs.Supplement.ListSupplementDTO>>(supplementList);
        }

        public static Supplement AddSupplementDTOToSupplement(AddSupplementDTO dto)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<AddSupplementDTO, Supplement>()
            .ForMember(dest => dest.RiskRatio, opt => opt.MapFrom(src => src.Risk)));

            var mapper = new Mapper(mapperConfig);
            return mapper.Map<Supplement>(dto);
        }
        public static AddSupplementDTO SupplementToGetListSupplementDTO(Supplement supplement)
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Supplement, AddSupplementDTO>()
                   .ForMember(dest => dest.Risk, opt => opt.MapFrom(src => src.RiskRatio));
            });
            var mapper = new Mapper(mapperConfig);
            return mapper.Map<AddSupplementDTO>(supplement);
        }

        #endregion

        #region Category

        public static List<CategoryDTO> CategoryListToCategoryDTOList(List<Category> categoryList)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryDTO>());

            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<CategoryDTO>>(categoryList);
        }

        #endregion

        #region Supplier

        public static List<SupplierDTO> SupplierListToSupplierDTOList(List<Supplier> supplierList)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<Supplier, SupplierDTO>());

            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<SupplierDTO>>(supplierList);
        }

        #endregion

        #region User

        public static User AddUserDTOtoUser(AddUserDTO dt)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<AddUserDTO, User>());

            var mapper = new Mapper(mapperConfig);
            return mapper.Map<User>(dt);
        }
        public static User UserForAdminDTOtoUser(UserForAdminDTO dt)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<UserForAdminDTO, User>());

            var mapper = new Mapper(mapperConfig);
            return mapper.Map<User>(dt);
        }

        public static UserDetailDTO UserToGetUserDetailDTO(User user)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<User, UserDetailDTO>());

            var mapper = new Mapper(mapperConfig);
            return mapper.Map<UserDetailDTO>(user);
        }

        #endregion

        #region FavList

        public static List<FavListDTO> FavListToFavListDTO(List<FavList> favLists)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<FavList, FavListDTO>());

            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<FavListDTO>>(favLists);
        }

        public static FavList AddFavListDTOToFavList(AddFavListDTO dto)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<AddFavListDTO, FavList>());

            var mapper = new Mapper(mapperConfig);
            return mapper.Map<FavList>(dto);
        }

        public static List<ListProductDTO> ProductFavListListToListProductDTOList(List<ProductFavList> productFavLists)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<ProductFavList, ListProductDTO>()
                .ForMember(dest => dest.ProductID, opt => opt.MapFrom(src => src.Product.ProductID))
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName)));

            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<ListProductDTO>>(productFavLists);
        }

        #endregion

        #region BlackList

        public static BlackList AddBlackListDTOToBlackList(IDDTO dto)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<IDDTO, BlackList>()
            .ForMember(dest => dest.UserID, opt => opt.MapFrom(src => src.ID)));

            var mapper = new Mapper(mapperConfig);
            return mapper.Map<BlackList>(dto);
        }

        public static BlackListDTO BlackListToBlackListDTO(BlackList blackList)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<BlackList, BlackListDTO>());

            var mapper = new Mapper(mapperConfig);

            return mapper.Map<BlackListDTO>(blackList);
        }

        public static List<SupplementDTO> SupplementBlackListListToSupplementDTOList(List<SupplementBlackList> supplementBlackLists)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<SupplementBlackList, SupplementDTO>()
                .ForMember(dest => dest.SupplementID, opt => opt.MapFrom(src => src.Supplement.SupplementID))
                .ForMember(dest => dest.SupplementName, opt => opt.MapFrom(src => src.Supplement.SupplementName)));

            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<SupplementDTO>>(supplementBlackLists);
        }

        #endregion

        #region SupplementBlackList

        //public static List<DTOs.UserBlackList.ListSupplementDTO> SupplementBlackListToGetListToSupplementBlackListDTO(List<SupplementBlackList> suppblackList)
        //{
        //    var mapperConfig = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<SupplementBlackList, DTOs.UserBlackList.ListSupplementDTO>()
        //           .ForMember(dest => dest.SupplementName, opt => opt.MapFrom(src => src.Supplement.SupplementName));
        //    });
        //    var mapper = new Mapper(mapperConfig);
        //    return mapper.Map<List<DTOs.UserBlackList.ListSupplementDTO>>(suppblackList);
        //}

        #endregion

        #region Search History

        public static List<SearchHistoryDTO> SearchHistoryListToSearchHistoryDTOListWithInclude(List<SearchHistory> searchHistoryList)
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SearchHistory, SearchHistoryDTO>()
                   .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName))
                   .ForMember(dest => dest.SearchDate, opt => opt.MapFrom(src => src.CreatedDate))
                   .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.User.FirstName + " " + src.User.LastName));
            });
            var mapper = new Mapper(mapperConfig);
            return mapper.Map<List<SearchHistoryDTO>>(searchHistoryList);
        }

        public static SearchHistory AddSearchHistoryDTOToSearchHistory(AddSearchHistoryDTO dto)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<AddSearchHistoryDTO, SearchHistory>());

            var mapper = new Mapper(mapperConfig);
            return mapper.Map<SearchHistory>(dto);
        }

        public static List<SearchHistoryDTO> SearchHistoryListToSearchHistoryDTOList(List<SearchHistory> searchHistories)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<SearchHistory, SearchHistoryDTO>());

            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<SearchHistoryDTO>>(searchHistories);
        }

        #endregion

        #region ProductSupplemnt

        public static List<ListSupplementDTO> ProductSupplementListToListSupplementDTOList(List<ProductSupplement> productSupplements)
        {
            var mapperConfig = new MapperConfiguration(cfg => cfg.CreateMap<ProductSupplement, ListSupplementDTO>()
                .ForMember(dest => dest.RiskRatio, opt => opt.MapFrom(src => src.Supplement.RiskRatio))
                .ForMember(dest => dest.SupplementName, opt => opt.MapFrom(src => src.Supplement.SupplementName)));

            var mapper = new Mapper(mapperConfig);

            return mapper.Map<List<ListSupplementDTO>>(productSupplements);
        }

        #endregion

    }
}
