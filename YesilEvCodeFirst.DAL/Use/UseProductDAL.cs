using NLog;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.Supplement;
using YesilEvCodeFirst.ExceptionHandling;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.Product;
using YesilEvCodeFirst.Validation.Urun;

namespace YesilEvCodeFirst.DAL.Use
{
    // todo: risk seviyesi duzenlenecek

    public class UseProductDAL : EfRepoBase<YesilEvDbContext, Product>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();
        public bool AddProduct(AddProductDTO dto)
        {
            AddProductValidator validator = new AddProductValidator(dto);
            try
            {
                if (!validator.IsValid)
                {
                    throw new ModelNotValidException(validator.ValidationMessages);
                }


                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var tempProduct = context.Product.Where(p => p.Barcode.Equals(dto.Barcode)).FirstOrDefault();
                    if (tempProduct == null)
                    {
                        Product eklenecekUrun = MappingProfile.AddProductDTOToProduct(dto);
                        context.Product.Add(eklenecekUrun);
                        // todo: refactor edilecek
                        context.SaveChanges();

                        var supplements = eklenecekUrun.ProductContent.Split(',');
                        for (int i = 0; i < supplements.Length; i++)
                        {
                            string sup = supplements[i].Trim();
                            var result = context.Supplement.Where(s => s.SupplementName.ToLower().Equals(sup.ToLower())).FirstOrDefault();
                            if (result == null)
                            {
                                //context.Supplement.Add(new Supplement { SupplementName = supplements[i] });
                                // todo: UseSupplementDal'ı burada kullanmaya gerek var mi? Yukaridaki kullanim da var.
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
                        nLogger.Info("{} Product tablosuna eklendi.", dto.ProductName);
                    }
                    else
                    {
                        throw new Exception("Urun zaten mevcut");
                    }
                }

                return true;
            }
            catch (ModelNotValidException ex)
            {
                nLogger.Error("Sytem - {}", ex.Message);
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }
            return false;
        }
        //to do throw exception bastırma yapılacak

        public bool UpdateProduct(UpdateProductDTO dto)
        {
            UpdateProductValidator validator = new UpdateProductValidator(dto);
            try
            {
                if (!validator.IsValid)
                {
                    throw new ModelNotValidException(validator.ValidationMessages);
                }
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    using (DbContextTransaction trans = context.Database.BeginTransaction())
                    {
                        try
                        {
                            var tempProduct = context.Product.Where(x => x.Barcode.Equals(dto.Barcode)).FirstOrDefault();
                            if (tempProduct != null && tempProduct.AddedBy == dto.AddedBy)
                            {
                                tempProduct.ProductName = dto.ProductName;
                                tempProduct.CategoryID = dto.CategoryID;
                                tempProduct.ProductContent = dto.ProductContent;
                                tempProduct.AddedBy = dto.AddedBy;
                                var supplements = tempProduct.ProductContent.Split(',');
                                //refactor edilecek
                                var temp = context.ProductSupplement.Where(x => x.ProductID == tempProduct.ProductID).ToList();
                                context.ProductSupplement.RemoveRange(temp);
                                MySaveChanges();
                                nLogger.Info("Urunun eski icerikleri silindi"); ;
                                for (int i = 0; i < supplements.Length; i++)
                                {
                                    string sup = supplements[i].Trim();
                                    var result = context.Supplement.Where(s => s.SupplementName.ToLower().Equals(sup.ToLower())).FirstOrDefault();
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
                                tempProduct.PictureBackPath = dto.PictureBackPath;
                                tempProduct.PictureFronthPath = dto.PictureFronthPath;
                                tempProduct.SupplierID = dto.SupplierID;
                                context.SaveChanges();
                                trans.Commit();
                                nLogger.Info("{} urunu guncellendi", tempProduct.ProductName);
                            }
                            else if (tempProduct.AddedBy != dto.AddedBy)
                            {

                                throw new Exception("Urun Kullaniciya ait degil");
                            }
                            else
                            {
                                throw new Exception("Urun mevcut değil");
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            throw new Exception("Urun Eklerken hata olustu");
                        }
                        finally
                        {
                            trans.Dispose();
                        }
                       
                        return true;
                    }
                }
            }
            catch (ModelNotValidException ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }
            return false;
        }

        public List<ListProductDTO> GetProductList()
        {
            try
            {
                List<Product> products= null;
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    List<Product> productList = context.Product.ToList();
                    products = productList;
                }
                if(products == null)
                {
                    throw new Exception("Listelenecek urun bulunamadi.");
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
            }

            return null;
        }
        
        public List<ListProductDTO> GetProductListWithUserID(int userID)
        {
            try
            {
                List<Product> products = null;
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    List<Product> productList = context.Product.Where(x=>x.AddedBy == userID).ToList();
                    products = productList;
                }
                if (products == null)
                {
                    throw new Exception("Listelenecek urun bulunamadi.");
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
            }

            return null;
        }
       
        public List<ListProductDTO> GetProductListForSearchbar(string filter)
        {
            // todo: burada try-catch yapisi gereksiz degil mi?
            try
            {
                List<ListProductDTO> listProductDTOList = MappingProfile.ProductListToProductListDTO(GetByCondition(x => x.ProductName.ToLower().Contains(filter.ToLower())));
                //log alinacak mi? her harf girildiginde log almak saglikli olmaz.
                return listProductDTOList;
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }

            return null;
        }

        public GetProductDetailDTO GetProductDetailWithBarcode(string barcode)
        {
            // barcode validator
            try
            {
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    // todo: burada this.getbycondition metodu mu kullanmaliyiz, context.products.. seklinde mi yapmaliyiz.
                    Product product = this.GetByConditionWithInclude(p => p.Barcode.Equals(barcode), "Supplier", "Category").FirstOrDefault();
                    if (product != null)
                    {
                        nLogger.Info("{} urunun detaylari getirildi", product.ProductName);
                        return MappingProfile.ProductToGetProductDetailDTO(product);
                    }
                    else
                    {
                        //  Eşleşmezse, yeni ürün ekleme sayfası gelecek ve doldurulması gereken formda barkod no hazır olarak gözükecek.
                        throw new Exception("Urun bulunamadi");
                    }
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }

            return null;
        }

        public GetProductDetailDTO GetProductDetailWithID(int id)
        {
            // barcode validator
            try
            {
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    // todo: burada this.getbycondition metodu mu kullanmaliyiz, context.products.. seklinde mi yapmaliyiz.
                    Product product = this.GetByConditionWithInclude(p => p.ProductID.Equals(id), "Supplier", "Category").FirstOrDefault();
                    if (product != null)
                    {
                        nLogger.Info("{} urunun detaylari getirildi", product.ProductName);
                        return MappingProfile.ProductToGetProductDetailDTO(product);
                    }
                    else
                    {
                        //  Eşleşmezse, yeni ürün ekleme sayfası gelecek ve doldurulması gereken formda barkod no hazır olarak gözükecek.
                        throw new Exception("Urun bulunamadi");
                    }
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
