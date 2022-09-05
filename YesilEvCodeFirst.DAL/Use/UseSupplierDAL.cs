using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs.Supplier;
using YesilEvCodeFirst.Mapping;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseSupplierDAL : EfRepoBase<YesilEvDbContext, Supplier>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        public List<SupplierDTO> GetSupplierList()
        {
            try
            {
                List<Supplier> suppliers = null;

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var result = context.Supplier.ToList();

                    suppliers = result;
                }
                if(suppliers == null)
                {
                    throw new Exception(Messages.SupplierNotFoundForList);
                }
                else
                {
                    List<SupplierDTO> supplierDTOList = MappingProfile.SupplierListToSupplierDTOList(suppliers);
                    nLogger.Info("Supplier tablosu listelendi");
                    return supplierDTOList;
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System- {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
