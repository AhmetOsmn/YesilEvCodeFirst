using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.Mapping;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseProductFavListDAL : EfRepoBase<YesilEvDbContext, ProductFavList>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        public List<ListProductDTO> GetProductsWithFavListID(int id)
        {
            try
            {
                List<ProductFavList> products = GetByConditionWithInclude(u => u.FavListID.Equals(id),"Product").ToList();
                if (products != null)
                {
                    nLogger.Info("{} ID'li kullanicinin favori listeleri getirildi.", id);
                    return MappingProfile.ProductFavListListToListProductDTOList(products);
                }
                else
                {
                    throw new Exception("Liste bulunamadı");
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }

            return null;
        }
    }
}
