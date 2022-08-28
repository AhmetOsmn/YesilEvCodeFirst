using System;
using System.Collections.Generic;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Concrete;
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
                SupplierDAL dal = new SupplierDAL();
                List<SupplierDTO> productDTOList = MappingProfile.SupplierListToSupplierDTOList(dal.GetAll());
                LogExtension.LogFunc(myLog, "", "Ahmet", "Listeleme islemi basarili", "Supplier", Islem.Info);
                return productDTOList;
            }
            catch (Exception ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Supplier", Islem.Error);
            }

            return null;
        }
    }
}
