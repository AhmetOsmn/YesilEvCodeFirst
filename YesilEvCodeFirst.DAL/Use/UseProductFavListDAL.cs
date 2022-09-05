using FluentValidation.Results;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.ProductFavList;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.FluentValidator;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseProductFavListDAL : EfRepoBase<YesilEvDbContext, ProductFavList>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();
        public bool AddProductToFavList(AddProductFavListDTO dto)
        {
            ProductFavListValidator validator = new ProductFavListValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var list = context.ProductFavList.Where(u => u.FavorID.Equals(dto.FavorID) && u.ProductID.Equals(dto.ProductID)).FirstOrDefault();
                    if (list == null)
                    {
                        context.ProductFavList.Add(new ProductFavList
                        {
                            ProductID = dto.ProductID,
                            FavorID = dto.FavorID
                        });
                        context.SaveChanges();
                    }
                    else if (list != null)
                    {
                        list.IsActive = true;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception(Messages.ProductAlreadyExistInList);
                    }
                }
                nLogger.Info("Ürün Ve Favori liste tablosuna ekleme işlemi yapıldı.");
                return true;
            }
            catch (FormatException fex)
            {
                nLogger.Error("System - {}", fex.Message);
                throw new FormatException(fex.Message);
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }
        public bool DeleteProductFavList(AddProductFavListDTO dto)
        {
            ProductFavListValidator validator = new ProductFavListValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var profavlist = context.ProductFavList.Where(u => u.FavorID.Equals(dto.FavorID) && u.ProductID.Equals(dto.ProductID)).FirstOrDefault();
                    if (profavlist != null)
                    {
                        profavlist.IsActive = false;
                        profavlist.CreatedDate = DateTime.Now;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception(Messages.ProductNotFoundForList);
                    }
                }

                nLogger.Info("Ürün ve Favori tablosundan silme işlemi yapıldı.");

                return true;
            }
            catch (FormatException fex)
            {
                nLogger.Error("System - {}", fex.Message);
                throw new FormatException(fex.Message);
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }
        public List<ListProductDTO> GetProductsWithFavListID(IDDTO dto)
        {
            IDDTOValidator validator = new IDDTOValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                List<ProductFavList> products = GetByConditionWithInclude(u => u.FavorID.Equals(dto.ID) && u.IsActive, "Product").ToList();
                if (products != null)
                {
                    nLogger.Info("{} ID'li kullanicinin favori listeleri getirildi.", dto.ID);
                    return MappingProfile.ProductFavListListToListProductDTOList(products);
                }
                else
                {
                    throw new Exception(Messages.ProductNotFoundForList);
                }
            }
            catch (FormatException fex)
            {
                nLogger.Error("System - {}", fex.Message);
                throw new FormatException(fex.Message);
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }
        public bool IsFavoriListHaveTheProduct(FavListProductDTO dto)
        {
            FavListProductDTOValidator validator = new FavListProductDTOValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                var result = GetByCondition(u => u.FavorID == dto.FavListID && u.ProductID == dto.ProductID && u.IsActive == true).FirstOrDefault();
                nLogger.Error("{} ID'li favori listenin {} Id'li ürün var mı kontrol edildi.", dto.FavListID, dto.ProductID);
                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (FormatException fex)
            {
                nLogger.Error("System - {}", fex.Message);
                throw new FormatException(fex.Message);
            }
        }
    }
}
