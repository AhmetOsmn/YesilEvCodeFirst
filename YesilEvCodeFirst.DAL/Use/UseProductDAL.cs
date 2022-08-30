using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Transactions;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.ExceptionHandling;
using YesilEvCodeFirst.Logs.Concrete;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.Product;
using YesilEvCodeFirst.Validation.Urun;

namespace YesilEvCodeFirst.DAL.Use
{
    // todo: bazı yerlere nlog eklenecek
    // todo: urun eklerken icerisindeki maddeler, maddeler tablosuna eklenmeli.
    // todo: urun eklerken supplementlerinin ayni olup olmadigi kontrol edilecek
    // todo: risk seviyesi duzenlenecek

    public class UseProductDAL : EfRepoBase<YesilEvDbContext, Product>
    {
        JsonLogger<LogDTO> myLog = new JsonLogger<LogDTO>("MyLog.txt");
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
                    // todo: burada urun ve madde tablosuna eklerken ProductSupplement tablosuna da eklenmeli
                    using (var dbContextTransection = context.Database.BeginTransaction())
                    {
                        try
                        {
                            var tempProduct = context.Product.Where(p => p.Barcode.Equals(dto.Barcode)).FirstOrDefault();
                            if (tempProduct == null)
                            {
                                Product eklenecekUrun = MappingProfile.AddProductDTOToProduct(dto);
                                var supplements = eklenecekUrun.ProductContent.Trim(' ').Split(',');
                                for (int i = 0; i < supplements.Length; i++)
                                {
                                    string sup = supplements[i];
                                    var result = context.Supplement.Where(s => s.SupplementName.ToLower().Equals(sup.ToLower())).FirstOrDefault();
                                    if (result == null)
                                    {
                                        context.Supplement.Add(new Supplement { SupplementName = supplements[i] });
                                    }
                                }
                                context.Product.Add(eklenecekUrun);
                                context.SaveChanges();
                                dbContextTransection.Commit();
                            }
                            else
                            {
                                throw new Exception("Urun zaten mevcut");
                            }
                        }
                        catch (Exception ex)
                        {
                            dbContextTransection.Rollback();
                            throw new Exception(ex.Message);
                        }
                        finally
                        {
                            dbContextTransection.Dispose();
                        }
                    }
                }

                LogExtension.LogFunc(myLog, "", "Ahmet", "Ekleme islemi basarili", "Urun", Islem.Info);
                
                return true;
            }
            catch (ModelNotValidException ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Urun", Islem.Error);
            }
            catch (Exception ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Urun", Islem.Error);
            }
            return false;
        }

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
                            if (tempProduct != null)
                            {
                                tempProduct.ProductName = dto.ProductName;
                                tempProduct.CategoryID = dto.CategoryID;
                                tempProduct.ProductContent = dto.ProductContent;
                                tempProduct.PictureBackPath = dto.PictureBackPath;
                                tempProduct.PictureFronthPath = dto.PictureFronthPath;
                                tempProduct.SupplierID = dto.SupplierID;
                                context.SaveChanges();
                                trans.Commit();
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
                        LogExtension.LogFunc(myLog, "", "Ahmet", "Update islemi basarili", "Urun", Islem.Info);
                        return true;
                    }
                }

            }
            catch (ModelNotValidException ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Urun", Islem.Error);
            }
            catch (Exception ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Urun", Islem.Error);
            }
            return false;
        }

        public List<ListProductDTO> GetProductList()
        {
            try
            {
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    List<Product> productList = context.Product.ToList();
                    List<ListProductDTO> productDTOList = MappingProfile.ProductListToProductListDTO(productList);
                    LogExtension.LogFunc(myLog, "", "Ahmet", "Listeleme islemi basarili", "Urun", Islem.Info);
                    return productDTOList;
                }
                
            }
            catch (Exception ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Urun", Islem.Error);
            }

            return null;
        }

        public List<ListProductDTO> GetProductListForSearchbar(string filter)
        {
            try
            {
                List<ListProductDTO> listProductDTOList = MappingProfile.ProductListToProductListDTO(GetByCondition(x => x.ProductName.ToLower().Contains(filter.ToLower())));
                //log alinacak mi? her harf girildiginde log almak saglikli olmaz.
                return listProductDTOList;
            }
            catch (Exception ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Urun", Islem.Error);
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
                    Product product = this.GetByConditionWithInclude(p => p.Barcode.Equals(barcode),"Supplier","Category").FirstOrDefault();
                    if (product != null)
                    {
                        //mapping Urun -> GetProductDetailDTO
                        LogExtension.LogFunc(myLog, "", "Ahmet", "Detay getirme basarili", "Urun", Islem.Info);
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
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Urun", Islem.Info);
            }

            return null;
        }
    }
}
