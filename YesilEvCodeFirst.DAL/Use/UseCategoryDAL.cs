using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs.Category;
using YesilEvCodeFirst.Mapping;

namespace YesilEvCodeFirst.DAL.Use
{

    public class UseCategoryDAL : EfRepoBase<YesilEvDbContext, Category>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        public List<CategoryDTO> GetCategoryList()
        {
            try
            {
                List<Category> categories = null;

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var result = context.Category.ToList();

                    categories = result;
                }
                if (categories == null)
                {
                    throw new Exception(Messages.CategoryNotFound);
                }
                else
                {
                    List<CategoryDTO> productDTOList = MappingProfile.CategoryListToCategoryDTOList(categories);

                    nLogger.Info("Category tablosu listelendi.");

                    return productDTOList;
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
