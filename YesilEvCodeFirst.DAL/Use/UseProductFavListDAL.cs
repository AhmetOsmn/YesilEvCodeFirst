using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs.Product;
using YesilEvCodeFirst.DTOs.ProductFavList;
using YesilEvCodeFirst.DTOs.SupplementBlackList;
using YesilEvCodeFirst.Mapping;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseProductFavListDAL : EfRepoBase<YesilEvDbContext, ProductFavList>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();
        public bool AddProductToFavList(AddProductFavListDTO dto)
        {
            try
            {
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    try
                    {
                        var favlist = context.FavList.Where(u => u.FavorID.Equals(dto.FavorID)).FirstOrDefault();
                        var list = context.ProductFavList.Where(u => u.FavorID.Equals(dto.FavorID) && u.ProductID.Equals(dto.ProductID)).FirstOrDefault();
                        if (favlist == null)
                        {
                            /*
                            context.FavList.Add(new FavList
                            {
                                FavorID = dto.FavorID
                            });
                            context.SaveChanges();
                            context.ProductFavList.Add(new ProductFavList
                            {
                                ProductID = dto.ProductID,
                                FavorID = context.FavList.LastOrDefault().FavorID
                            });
                            context.SaveChanges();*/
                        }
                        else if (list == null)
                        {
                            context.ProductFavList.Add(new ProductFavList
                            {
                                ProductID = dto.ProductID,
                                FavorID = dto.FavorID
                            });
                            context.SaveChanges();
                        }
                        else if(list != null){
                            list.IsActive = true;
                            context.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("Listeden bulunan ürün tekrar listeye eklenemez.");
                        }

                    }
                    catch (Exception ex)
                    {

                        
                    }

                }

                nLogger.Info("Ürün Ve Favori liste tablosuna ekleme işlemi yapıldı.");

                return true;
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }

            return false;
        }
        public bool DeleteProductFavList(AddProductFavListDTO dto)
        {
            try
            {
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
                        throw new Exception("Silme işlemi yapılamadı.");
                    }

                }

                nLogger.Info("Ürün ve Favori tablosundan silme işlemi yapıldı.");

                return true;
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }
            return false;
        }
        public List<ListProductDTO> GetProductsWithFavListID(int id)
        {
            try
            {
                List<ProductFavList> products = GetByConditionWithInclude(u => u.FavorID.Equals(id) && u.IsActive, "Product").ToList();
                if (products != null)
                {
                    nLogger.Info("{} ID'li kullanicinin favori listeleri getirildi.", id);
                    return MappingProfile.ProductFavListListToListProductDTOList(products);
                }
                else
                {
                    throw new Exception("Liste bulunamadı");
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }

            return null;
        }
        public bool IsFavoriListHaveTheProduct(int favoriId,int productId)
        {
            try
            {
                var result = GetByCondition(u=> u.FavorID == favoriId && u.ProductID == productId && u.IsActive == true).FirstOrDefault();
                nLogger.Error("{} ID'li favori listenin {} Id'li ürün var mı kontrol edildi.", favoriId,productId);
                if(result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }
            return false;
        }
    }
}
