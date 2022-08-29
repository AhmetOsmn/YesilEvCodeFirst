﻿using System;
using System.Collections.Generic;
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
                   // begin transection

                    var tempProduct = context.Product.Where(p => p.Barcode.Equals(dto.Barcode)).FirstOrDefault();
                    if (tempProduct == null)
                    {
                        Product eklenecekUrun = MappingProfile.AddProductDTOToProduct(dto);
                        var supplements = eklenecekUrun.ProductContent.Trim(' ').Split(',');
                        for (int i = 0; i < supplements.Length; i++)
                        {
                            string sup = supplements[i];
                            var result = context.Supliment.Where(s => s.SupplementName.ToLower().Equals(sup.ToLower())).FirstOrDefault();
                            if (result == null)
                            {
                                context.Supliment.Add(new Supplement { SupplementName = supplements[i] });
                            }
                        }
                        context.Product.Add(eklenecekUrun);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Urun zaten mevcut");
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
                if(!validator.IsValid)
                {
                    throw new ModelNotValidException(validator.ValidationMessages);
                }

                //ProductDAL dal = new ProductDAL();
                //var tempProduct = dal.GetByCondition(x => x.Barcode.Equals(dto.Barcode)).SingleOrDefault();
                ////tempProduct = MappingProfile.UpdateProductDTOToProduct(dto);
                //tempProduct.ProductName = dto.ProductName;
                //tempProduct.Barcode = dto.Barcode;
                //tempProduct.CategoryID = dto.CategoryID;
                //tempProduct.SupplierID = dto.SupplierID;
                //tempProduct.ProductContent = dto.ProductContent;
                //tempProduct.PictureFronthPath = dto.PictureFronthPath;
                ////tempProduct.PictureBackPath = dto.PictureBackPath;

                //dal.Update(tempProduct);
                //dal.MySaveChanges();
                //LogExtension.LogFunc(myLog, "", "Ahmet", "Guncelleme islemi basarili", "Urun", Islem.Info);
                //return true;
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
                //ProductDAL dal = new ProductDAL();
                //List<ListProductDTO> productDTOList = MappingProfile.ProductListToProductListDTO(dal.GetAll());
                //LogExtension.LogFunc(myLog, "", "Ahmet", "Listeleme islemi basarili", "Urun", Islem.Info);
                //return productDTOList;
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
                //ProductDAL dal = new ProductDAL();
                //List<ListProductDTO> listProductDTOList = MappingProfile.ProductListToProductListDTO(dal.GetByCondition(x => x.ProductName.ToLower().Contains(filter.ToLower())));
                ////log alinacak mi? her harf girildiginde log almak saglikli olmaz.
                //return listProductDTOList;
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
                //ProductDAL dal = new ProductDAL();
                //Product product = dal.GetByConditionWithInclude(produtct => produtct.Barcode.Equals(barcode), "Supplier", "Category").SingleOrDefault();
                //if (product != null)
                //{
                //    //mapping Urun -> GetProductDetailDTO
                //    GetProductDetailDTO urunDetail = MappingProfile.ProductToGetProductDetailDTO(product);
                //    LogExtension.LogFunc(myLog, "", "Ahmet", "Detay getirme basarili", "Urun", Islem.Info);
                //    return urunDetail;
                //}
                //else
                //{
                //    //  Eşleşmezse, yeni ürün ekleme sayfası gelecek ve doldurulması gereken formda barkod no hazır olarak gözükecek.
                //    throw new Exception("Urun bulunamadi");
                //}
            }
            catch (Exception ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Urun", Islem.Info);
            }

            return null;
        }
    }
}
