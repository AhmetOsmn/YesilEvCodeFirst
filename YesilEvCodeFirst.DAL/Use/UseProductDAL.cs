using System;
using System.Collections.Generic;
using System.Linq;
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
                // maddeler split(",")
                dal.Add(eklenecekUrun);

                dal.MySaveChanges();

                LogFunc(myLog, "", "Osman", "Ekleme islemi basarili", "Urun", Islem.Info);

                return true;
            }
            catch (ModelNotValidException ex)
            {
                LogFunc(myLog, "", "Ahmet", ex.Message, "Urun", Islem.Error);
            }
            catch (Exception ex)
            {
                LogFunc(myLog, "", "Ahmet", ex.Message, "Urun", Islem.Error);
            }
            return false;
        }

        public List<ListProductDTO> GetProductList()
        {
            try
            {
                ProductDAL dal = new ProductDAL();

                var urunler = dal.GetAll();
                List<ListProductDTO> urunList = MappingProfile.ProductListToProductListDTO(urunler);
                LogFunc(myLog, "", "Ahmet Osman", "Listeleme islemi basarili", "Urun", Islem.Info);
                return urunList;
            }
            catch (Exception ex)
            {

                LogFunc(myLog, "", "Ahmet Osman", ex.Message, "Urun", Islem.Error);
            }

            return null;
        }
        
        public GetProductDetailDTO GetProductDetailWithBarcode(string barcode)
        {
            // new barcodeValidator
            try
            {
                // validasyon
                //if (!validator.IsValid)
                //{
                //    throw new ModelNotValidException(validator.ValidationMessages);
                //}

                ProductDAL dal = new ProductDAL();
                Product product = dal.GetByConditionWithInclude(produtct => produtct.Barcode.Equals(barcode),"Supplier","Category").SingleOrDefault();
                if(product != null)
                {
                    //mapping Urun -> GetProductDetailDTO
                    GetProductDetailDTO urunDetail = MappingProfile.ProductToGetProductDetailDTO(product);
                    LogFunc(myLog, "", "Admin", "Detay getirme basarili", "Urun", Islem.Info);
                    return urunDetail;
                }
                else
                {
                    throw new Exception("Urun bulunamadi");
                }
            }
            catch (Exception ex)
            {
                LogFunc(myLog, "", "Admin", ex.Message, "Urun", Islem.Info);
            }
            return null;
        }

        private void LogFunc(JsonLogger<LogDTO> myLog, string dataID, string kisi, string not, string tablo, Islem islem)
        {
            myLog.Log(new LogDTO()
            {
                DataID = dataID,
                Islem = islem,
                Kisi = kisi,
                Not = not,
                Tablo = tablo,
                IslemTarihi = DateTime.Now
            });
        }
    }
}
