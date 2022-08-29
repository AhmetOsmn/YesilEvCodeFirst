using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Concrete;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.ExceptionHandling;
using YesilEvCodeFirst.Logs.Concrete;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.Product;
using YesilEvCodeFirst.Validation.Urun;

namespace YesilEvCodeFirst.DAL.Use
{
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
                ProductDAL dal = new ProductDAL();
                Product eklenecekUrun = MappingProfile.AddProductDTOToProduct(dto);
                // todo: urun eklerken icerisindeki maddeler, maddeler tablosuna eklenmeli.
                // maddeler split(",")
                dal.Add(eklenecekUrun);
                dal.MySaveChanges();
                LogExtension.LogFunc(myLog, "", "Ahmet", "Ekleme islemi basarili", "Urun", Islem.Info);
                // todo: bazı yerlere nlog eklenecek

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

                ProductDAL dal = new ProductDAL();
                var tempProduct = dal.GetByCondition(x => x.Barcode.Equals(dto.Barcode)).SingleOrDefault();
                //tempProduct = MappingProfile.UpdateProductDTOToProduct(dto);
                tempProduct.ProductName = dto.ProductName;
                tempProduct.Barcode = dto.Barcode;
                tempProduct.CategoryID = dto.CategoryID;
                tempProduct.SupplierID = dto.SupplierID;
                tempProduct.ProductContent = dto.ProductContent;
                tempProduct.PictureFronthPath = dto.PictureFronthPath;
                tempProduct.PictureBackPath = dto.PictureBackPath;

                dal.Update(tempProduct);
                dal.MySaveChanges();
                LogExtension.LogFunc(myLog, "", "Ahmet", "Guncelleme islemi basarili", "Urun", Islem.Info);
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

        public List<ListProductDTO> GetProductList()
        {
            try
            {
                ProductDAL dal = new ProductDAL();
                List<ListProductDTO> productDTOList = MappingProfile.ProductListToProductListDTO(dal.GetAll());
                LogExtension.LogFunc(myLog, "", "Ahmet", "Listeleme islemi basarili", "Urun", Islem.Info);
                return productDTOList;
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
                ProductDAL dal = new ProductDAL();
                List<ListProductDTO> listProductDTOList = MappingProfile.ProductListToProductListDTO(dal.GetByCondition(x => x.ProductName.ToLower().Contains(filter.ToLower())));
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
                ProductDAL dal = new ProductDAL();
                Product product = dal.GetByConditionWithInclude(produtct => produtct.Barcode.Equals(barcode), "Supplier", "Category").SingleOrDefault();
                if (product != null)
                {
                    //mapping Urun -> GetProductDetailDTO
                    GetProductDetailDTO urunDetail = MappingProfile.ProductToGetProductDetailDTO(product);
                    LogExtension.LogFunc(myLog, "", "Ahmet", "Detay getirme basarili", "Urun", Islem.Info);
                    return urunDetail;
                }
                else
                {
                    //  Eşleşmezse, yeni ürün ekleme sayfası gelecek ve doldurulması gereken formda barkod no hazır olarak gözükecek.
                    throw new Exception("Urun bulunamadi");
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
