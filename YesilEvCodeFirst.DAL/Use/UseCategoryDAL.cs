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
                    var result = context.Category.Where(x => x.IsActive).ToList();

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

        public List<Category> GetCategoriesWithFilterForAdmin(string filter)
        {
            return GetByCondition(x => x.CategoryName.Contains(filter) && x.IsActive).ToList();
        }
        public Category GetCategoryDetailsWithCategoryName(string CategoryName)
        {
            return GetByCondition(x=>x.CategoryName.Equals(CategoryName)&&x.IsActive).SingleOrDefault();
        }
        public string GetCategoryNameWithCategoryID(int? CategoryID)
        {
            try
            {
                return GetByCondition(x => x.CategoryID == CategoryID && x.IsActive).SingleOrDefault().CategoryName;
            }
            catch(Exception ex)
            {
                throw new Exception(Messages.CategoryNotFound);
            }            
        }
        public bool DeleteCategory(CategoryDTO dto)
        {
            try
            {
                var result = GetByCondition(x => x.CategoryName == dto.CategoryName && x.IsActive).SingleOrDefault();
                
                if(result.UstCategoryID == result.CategoryID)
                {
                    throw new Exception("Bu kategorinin üst kategorisi bulunmadığından bu kategori silinemez");
                }
                else
                {
                    result.IsActive = false;
                    using (YesilEvDbContext context = new YesilEvDbContext())
                    {
                        var CategoryHasProducts = context.Product.Where(x=>x.CategoryID == result.CategoryID&& x.IsActive).ToList();
                        CategoryHasProducts.ForEach(x =>
                        {
                            x.CategoryID = (int) result.UstCategoryID;
                        });
                        MySaveChanges();
                    }
                }
                return true;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }            
        }

        public bool UpdateCategory(UpdateCategoryDTO dto)
        {
            try
            {
                var result = GetByCondition(x=>x.CategoryName == dto.CategoryName && x.IsActive).SingleOrDefault();
                if (result != null)
                {
                    result.UstCategoryID = dto.UstCategoryID;
                    result.CategoryName = dto.CategoryName;
                    MySaveChanges();
                    return true;
                }
                else
                {
                    throw new Exception(Messages.CategoryNotFound);
                } 
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool AddCategory(AddCategoryDTO dto)
        {
            try
            {
                Category category = MappingProfile.AddCategoryDTOToCategory(dto);
                Add(category);
                MySaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Kategori Eklenirken Hata Oluştu.");
            }
        }
    }
}
