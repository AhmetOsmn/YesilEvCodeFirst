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
using YesilEvCodeFirst.DTOs.UserFavList;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.FluentValidator;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseFavListDAL : EfRepoBase<YesilEvDbContext, FavList>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        public bool AddFavList(AddFavListDTO dto)
        {
            AddFavListValidator validator = new AddFavListValidator();
            ValidationResult validationResult = validator.Validate(dto);
            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var favlist = context.FavList.Where(u => u.UserID.Equals(dto.UserID)).FirstOrDefault();
                    FavList addfavlist = MappingProfile.AddFavListDTOToFavList(dto);
                    context.FavList.Add(addfavlist);
                    context.SaveChanges();
                }

                nLogger.Info("Favori liste tablosuna ekleme işlemi yapıldı.");

                return true;
            }
            catch (FormatException fex)
            {
                nLogger.Error("System - {}", fex.Message);
                throw new FormatException(fex.Message);
            }
        }
        public bool DeleteFavList(EditFavListDTO dto)
        {
            DeleteFavListValidator validator = new DeleteFavListValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var favlist = context.FavList.Where(u => u.UserID.Equals(dto.UserID) && u.FavorID.Equals(dto.FavorID) && u.IsActive).FirstOrDefault();
                    if (favlist != null)
                    {
                        favlist.IsActive = false;
                        // todo: modified date olması gerekmiyor mu?
                        favlist.CreatedDate = DateTime.Now;

                        var favlistProducts = context.ProductFavList.Where(x => x.FavorID == dto.FavorID && x.IsActive).ToList();
                        favlistProducts.ForEach(x => x.IsActive = false);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception(Messages.FavListNotFound);
                    }
                }

                nLogger.Info("Favori liste tablosundan silme işlemi yapıldı.");

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
        public bool UpdateFavList(EditFavListDTO dto)
        {
            UpdateFavListValidator validator = new UpdateFavListValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var favlist = context.FavList.Where(u => u.UserID.Equals(dto.UserID) && u.FavorID.Equals(dto.FavorID) && u.IsActive).FirstOrDefault();
                    if (favlist != null)
                    {
                        favlist.FavoriListName = dto.FavoriListName;
                        favlist.CreatedDate = DateTime.Now;
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception(Messages.FavListNotFound);
                    }
                }

                nLogger.Info("Favori liste tablosundan silme işlemi yapıldı.");

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
        public List<FavListDTO> GetFavListsWithUserID(IDDTO dto)
        {
            IDDTOValidator validator = new IDDTOValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                var favlist = GetByCondition(u => u.UserID.Equals(dto.ID) && u.IsActive).ToList();
                if (favlist != null)
                {
                    nLogger.Info("{} ID'li kullanicinin favori listeleri getirildi.", dto.ID);
                    return MappingProfile.FavListToFavListDTO(favlist);
                }
                else
                {
                    throw new Exception(Messages.FavListNotFound);
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
        public int GetFavListIDWithFavListNameAndUserID(GetFavListIDWithFavListNameAndUserIDDTO dto)
        {
            GetFavListIDWithFavListNameAndUserIDValidator validator = new GetFavListIDWithFavListNameAndUserIDValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                var favlist = GetByCondition(u => u.UserID.Equals(dto.UserID) && u.FavoriListName.Equals(dto.FavListName) && u.IsActive).FirstOrDefault();
                if (favlist != null)
                {
                    nLogger.Info("{} ID'li kullanicinin {} listesinin ID'si getirildi.", dto.UserID, dto.FavListName);
                    return favlist.FavorID;
                }
                else
                {
                    throw new Exception(Messages.FavListNotFound);
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
    }
}
