using FluentValidation.Results;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.Supplement;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.FluentValidator;
using YesilEvCodeFirst.Validation.FluentValidator.Const;

namespace YesilEvCodeFirst.DAL.Use
{
    // todo: transaction eklenecek mi?
    public class UseProductDAL : EfRepoBase<YesilEvDbContext, Product>
    {
        
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();
        public bool AddProduct(AddProductDTO dto)
        {
            AddProductValidator validator = new AddProductValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var tempProduct = context.Product.Where(p => p.Barcode.Equals(dto.Barcode) && p.IsActive).FirstOrDefault();
                    if (tempProduct == null)
                    {
                        using (DbContextTransaction transaction = context.Database.BeginTransaction())
                        {
                            try
                            {
                                Product eklenecekUrun = MappingProfile.AddProductDTOToProduct(dto);
                                context.Product.Add(eklenecekUrun);
                                context.SaveChanges();

                                var supplements = eklenecekUrun.ProductContent.Split(',');
                                for (int i = 0; i < supplements.Length; i++)
                                {
                                    string sup = supplements[i].Trim();
                                    var result = context.Supplement.Where(s => s.SupplementName.ToLower().Equals(sup.ToLower()) && s.IsActive).FirstOrDefault();
                                    if (result == null)
                                    {
                                        UseSupplementDAL supplementDAL = new UseSupplementDAL();
                                        supplementDAL.AddSupplement(new AddSupplementDTO { SupplementName = sup });
                                        context.ProductSupplement.Add(new ProductSupplement()
                                        {
                                            ProductID = context.Product.ToList().LastOrDefault().ProductID,
                                            SupplementID = context.Supplement.ToList().LastOrDefault().SupplementID
                                        });
                                        nLogger.Info("{} - {} ProductSupplement tablosuna eklendi.", eklenecekUrun.ProductName, sup);
                                    }
                                    else
                                    {
                                        context.ProductSupplement.Add(new ProductSupplement()
                                        {
                                            ProductID = context.Product.ToList().LastOrDefault().ProductID,
                                            SupplementID = result.SupplementID
                                        });
                                        nLogger.Info("{} - {} ProductSupplement tablosuna eklendi.", dto.ProductName, sup);
                                    }
                                }
                                context.SaveChanges();

                                transaction.Commit();
                                nLogger.Info("{} Product tablosuna eklendi.", dto.ProductName);
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                throw new Exception(ex.Message);
                            }
                        }
                    }
                    else
                    {
                        throw new Exception(Messages.ProductAlreadyExist);
                    }
                }

                return true;
            }
            catch (FormatException fex)
            {
                nLogger.Error("Sytem - {}", fex.Message);
                throw new FormatException(fex.Message);
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public bool UpdateProduct(UpdateProductDTO dto)
        {
            UpdateProductValidator validator = new UpdateProductValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var tempProduct = context.Product.Where(x => x.Barcode.Equals(dto.Barcode) && x.IsActive).FirstOrDefault();

                    var adder = context.User.Where(x => x.UserID == dto.AddedBy).FirstOrDefault();

                    if (tempProduct != null && (tempProduct.AddedBy == dto.AddedBy || adder.RolID == 1))
                    {
                        tempProduct.ProductName = dto.ProductName;
                        tempProduct.CategoryID = dto.CategoryID;
                        tempProduct.ProductContent = dto.ProductContent;
                        tempProduct.AddedBy = dto.AddedBy;
                        tempProduct.PictureBackPath = dto.PictureBackPath;
                        tempProduct.PictureFronthPath = dto.PictureFronthPath;
                        tempProduct.PictureContentPath = dto.PictureContentPath;
                        tempProduct.SupplierID = dto.SupplierID;
                        MySaveChanges();
                        var supplements = tempProduct.ProductContent.Split(',');
                        //refactor edilecek
                        var temp = context.ProductSupplement.Where(x => x.ProductID == tempProduct.ProductID).ToList();
                        context.ProductSupplement.RemoveRange(temp);
                        MySaveChanges();
                        nLogger.Info("Urunun eski icerikleri silindi"); ;
                        for (int i = 0; i < supplements.Length; i++)
                        {
                            string sup = supplements[i].Trim();
                            var result = context.Supplement.Where(s => s.SupplementName.ToLower().Equals(sup.ToLower()) && s.IsActive).FirstOrDefault();
                            if (result == null)
                            {
                                UseSupplementDAL supplementDAL = new UseSupplementDAL();
                                supplementDAL.AddSupplement(new AddSupplementDTO { SupplementName = sup });
                                context.ProductSupplement.Add(new ProductSupplement()
                                {
                                    ProductID = tempProduct.ProductID,
                                    SupplementID = context.Supplement.ToList().LastOrDefault().SupplementID
                                });
                                nLogger.Info("{} - {} ProductSupplement tablosuna eklendi.", tempProduct.ProductName, sup);
                            }
                            else
                            {
                                context.ProductSupplement.Add(new ProductSupplement()
                                {
                                    ProductID = tempProduct.ProductID,
                                    SupplementID = result.SupplementID
                                });
                                nLogger.Info("{} - {} ProductSupplement tablosuna eklendi.", tempProduct.ProductName, sup);
                            }
                        }

                        context.SaveChanges();
                        nLogger.Info("{} urunu guncellendi", tempProduct.ProductName);
                        return true;
                    }
                    else if (tempProduct.AddedBy != dto.AddedBy)
                    {
                        throw new Exception(Messages.DoesNotBelongUser);
                    }
                    else
                    {
                        throw new Exception(Messages.ProductNotFound);
                    }
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

        public bool DeleteProduct(BarcodeDTO dto)
        {
            BarcodeDTOValidator validator = new BarcodeDTOValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                Product deletedProduct = GetByCondition(p => p.Barcode.Equals(dto.Barcode.Trim()) && p.IsActive).FirstOrDefault();

                if (deletedProduct != null)
                {
                    deletedProduct.IsActive = false;

                    MySaveChanges();
                    using (YesilEvDbContext context = new YesilEvDbContext())
                    {
                        var productSupplements = context.ProductSupplement.Where(x => x.ProductID == deletedProduct.ProductID).ToList();
                        productSupplements.ForEach( x => x.IsActive = false);

                        var productFavlists = context.ProductFavList.Where(x => x.ProductID == deletedProduct.ProductID).ToList();
                        productFavlists.ForEach( x => x.IsActive = false);

                        var productSearchHistories = context.SearchHistory.Where(x => x.ProductID == deletedProduct.ProductID).ToList();
                        productSearchHistories.ForEach( x => x.IsActive = false);

                        context.SaveChanges();
                    }

                    nLogger.Info("{} barkodlu ürün silindi.", dto.Barcode);
                    return true;
                }
                else
                {
                    throw new Exception(Messages.ProductNotFound);
                }
            }
            catch (FormatException fex)
            {
                nLogger.Error("System - {}", fex.Message);
                throw new Exception(fex.Message);
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public List<ListProductDTO> GetProductList()
        {
            try
            {
                List<Product> products = null;
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    List<Product> productList = context.Product.Where(x => x.IsActive).ToList();
                    products = productList;
                }
                if (products == null)
                {
                    throw new Exception(Messages.ProductListIsEmpty);
                }
                else
                {
                    List<ListProductDTO> productDTOList = MappingProfile.ProductListToProductListDTO(products);
                    nLogger.Info("Product tablosu listelendi.");
                    return productDTOList;
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public List<ListProductDTO> GetProductListWithUserID(IDDTO dto)
        {
            IDDTOValidator validator = new IDDTOValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                List<Product> products = null;
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    List<Product> productList = context.Product.Where(x => x.AddedBy == dto.ID && x.IsActive).ToList();
                    products = productList;
                }
                if (products == null)
                {
                    throw new Exception(Messages.ProductListIsEmpty);
                }
                else
                {
                    List<ListProductDTO> productDTOList = MappingProfile.ProductListToProductListDTO(products);
                    nLogger.Info("Product tablosu listelendi.");
                    return productDTOList;
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

        public List<ListProductDTO> GetProductListForSearchbar(string filter)
        {
            List<ListProductDTO> listProductDTOList = MappingProfile.ProductListToProductListDTO(GetByCondition(x => x.ProductName.ToLower().Contains(filter.ToLower()) && x.IsActive));
            return listProductDTOList;
        }

        public GetProductDetailDTO GetProductDetailWithBarcode(BarcodeDTO dto)
        {
            BarcodeDTOValidator validator = new BarcodeDTOValidator();
            ValidationResult validationResult = validator.Validate(dto);
            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    Product product = this.GetByConditionWithInclude(p => p.Barcode.Equals(dto.Barcode) && p.IsActive, "Supplier", "Category").FirstOrDefault();
                    if (product != null)
                    {
                        nLogger.Info("{} urunun detaylari getirildi", product.ProductName);
                        return MappingProfile.ProductToGetProductDetailDTO(product);
                    }
                    else
                    {
                        throw new Exception(Messages.ProductNotFound);
                    }
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

        public GetProductDetailDTO GetProductDetailWithProductID(IDDTO dto)
        {
            IDDTOValidator validator = new IDDTOValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    Product product = this.GetByConditionWithInclude(p => p.ProductID.Equals(dto.ID) && p.IsActive, "Supplier", "Category").FirstOrDefault();
                    if (product != null)
                    {
                        nLogger.Info("{} urunun detaylari getirildi", product.ProductName);
                        return MappingProfile.ProductToGetProductDetailDTO(product);
                    }
                    else
                    {
                        throw new Exception(Messages.ProductNotFound);
                    }
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

        public List<Product> GetProductsForAdmin()
        {
            try
            {
                // todo: inclue yapilarak getirilecek
                List<Product> products = GetByCondition(x => x.IsActive).ToList();
                if (products == null)
                {
                    throw new Exception(Messages.ProductListIsEmpty);
                }
                else
                {
                    nLogger.Info("Product tablosu admin tarafından listelendi.");
                    return products;
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public List<Product> GetProductListWithSearchbarForAdmin(string filter)
        {
            return GetByCondition(x => x.ProductName.ToLower().Contains(filter.ToLower()) && x.IsActive);
        }

        public List<Product> GetProductsForAdminApprove()
        {
            try
            {
                List<Product> products = GetByCondition(x => !x.IsApproved && x.IsActive);
                if (products == null)
                {
                    throw new Exception(Messages.ProductListIsEmpty);
                }
                else
                {
                    List<ListProductDTO> productDTOList = MappingProfile.ProductListToProductListDTO(products);
                    nLogger.Info("Product tablosu listelendi.");
                    return products;
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public bool UpdateIsApprovedForAdmin(int id, int approvedBy)
        {
            try
            {
                var updatedProduct = GetByCondition(x => x.ProductID == id && x.IsActive).SingleOrDefault();
                if (updatedProduct != null)
                {
                    updatedProduct.IsApproved = true;
                    updatedProduct.ApprovedBy = approvedBy;
                    MySaveChanges();
                    return true;
                }
                else
                {
                    throw new Exception(Messages.ProductNotFound);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
