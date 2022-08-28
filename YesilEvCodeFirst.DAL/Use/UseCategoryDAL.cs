using System;
using System.Collections.Generic;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Concrete;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Category;
using YesilEvCodeFirst.Logs.Concrete;
using YesilEvCodeFirst.Mapping;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseCategoryDAL : EfRepoBase<YesilEvDbContext, Category>
    {
        JsonLogger<LogDTO> myLog = new JsonLogger<LogDTO>("MyLog.txt");

        public List<CategoryDTO> GetCategoryList()
        {
            try
            {
                CategoryDAL dal = new CategoryDAL();
                List<CategoryDTO> productDTOList = MappingProfile.CategoryListToCategoryDTOList(dal.GetAll());
                LogExtension.LogFunc(myLog, "", "Ahmet", "Listeleme islemi basarili", "Category", Islem.Info);
                return productDTOList;
            }
            catch (Exception ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Category", Islem.Error);
            }

            return null;
        }
    }
}
