using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Category;
using YesilEvCodeFirst.Logs.Concrete;
using YesilEvCodeFirst.Mapping;

namespace YesilEvCodeFirst.DAL.Use
{
    // todo: metotlarin ustlerinde summary, icerisinde aciklamalar olmali.
    public class UseCategoryDAL : EfRepoBase<YesilEvDbContext, Category>
    {
        JsonLogger<LogDTO> myLog = new JsonLogger<LogDTO>("MyLog.txt");

        public List<CategoryDTO> GetCategoryList()
        {
            try
            {
                List<Category> categories = new List<Category>();

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var result = context.Category.ToList();

                    categories = result;
                }
                List<CategoryDTO> productDTOList = MappingProfile.CategoryListToCategoryDTOList(categories);
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
