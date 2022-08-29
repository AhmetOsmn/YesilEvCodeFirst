using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Supplier;
using YesilEvCodeFirst.Logs.Concrete;
using YesilEvCodeFirst.Mapping;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseSupplierDAL : EfRepoBase<YesilEvDbContext, Supplier>
    {
        JsonLogger<LogDTO> myLog = new JsonLogger<LogDTO>("MyLog.txt");

        public List<SupplierDTO> GetSupplierList()
        {
            try
            {                
                List<Supplier> suppliers = new List<Supplier>();

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var result = context.Supplier.ToList();

                    suppliers = result;
                }
                List<SupplierDTO> supplierDTOList = MappingProfile.SupplierListToSupplierDTOList(suppliers);
                LogExtension.LogFunc(myLog, "", "Ahmet", "Listeleme islemi basarili", "Supplier", Islem.Info);
                return supplierDTOList;
            }
            catch (Exception ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Supplier", Islem.Error);
            }

            return null;
        }
    }
}
