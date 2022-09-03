using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs.Supplement;
using YesilEvCodeFirst.Mapping;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseProductSupplementDAL : EfRepoBase<YesilEvDbContext, ProductSupplement>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        public List<ListSupplementDTO> GetSupplementsWithProductID(int productID)
        {
            try
            {
                List<ProductSupplement> productSupplements = GetByConditionWithInclude(u => u.ProductID.Equals(productID),"Supplement").ToList();
                if (productSupplements != null)
                {
                    nLogger.Info("{} ID'li urune ait olan maddeler getirildi.", productID);
                    return MappingProfile.ProductSupplementListToListSupplementDTOList(productSupplements);
                }
                else
                {
                    throw new Exception("maddeler bulunamadı");
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
