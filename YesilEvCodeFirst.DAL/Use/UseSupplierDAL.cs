using FluentValidation.Results;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs.Supplier;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.FluentValidator;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseSupplierDAL : EfRepoBase<YesilEvDbContext, Supplier>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        public List<SupplierDTO> GetSupplierList()
        {
            try
            {
                List<Supplier> suppliers = null;

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var result = context.Supplier.Where(x => x.IsActive).ToList();

                    suppliers = result;
                }
                if (suppliers == null)
                {
                    throw new Exception(ExceptionMessages.SupplierNotFoundForList);
                }
                else
                {
                    List<SupplierDTO> supplierDTOList = MappingProfile.SupplierListToSupplierDTOList(suppliers);
                    nLogger.Info("Supplier tablosu listelendi");
                    return supplierDTOList;
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System- {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public bool AddSupplier(AddSupplierDTO dto)
        {
            AddSupplierValidator validator = new AddSupplierValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                Supplier eklenecekUretici = GetByCondition(x => x.SupplierName.ToLower().Equals(dto.SupplierName.ToLower().Trim()) && x.IsActive).FirstOrDefault();
                if (eklenecekUretici == null)
                {
                    eklenecekUretici = new Supplier { SupplierName = dto.SupplierName};
                    Add(eklenecekUretici);
                    MySaveChanges();
                    nLogger.Info("{} Supplier tablosuna eklendi", dto.SupplierName);
                    return true;
                }
                else
                {
                    throw new Exception(ExceptionMessages.SupplierAlreadyExist);
                }

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

        public bool UpdateSupplier(UpdateSupplierDTO dto)
        {
            UpdateSupplierValidator validator = new UpdateSupplierValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                Supplier guncellenecekUretici = GetByCondition(x => x.SupplierName.ToLower().Equals(dto.SupplierName.ToLower().Trim()) && x.IsActive).FirstOrDefault();
                if (guncellenecekUretici != null)
                {
                    guncellenecekUretici.SupplierName = dto.SupplierNewName;
                    MySaveChanges();
                    nLogger.Info("{} üreticisi {} olarak güncellendi.", dto.SupplierName, dto.SupplierNewName);
                    return true;
                }
                else
                {
                    throw new Exception(ExceptionMessages.SupplierNotFound);
                }
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

        public bool DeleteSupplier(AddSupplierDTO dto)
        {
            // AddSupplier ile ayni dto olacagi icin DeleteSupplierDTO ve Validator olusturmadim.
            AddSupplierValidator validator = new AddSupplierValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                Supplier silinecekUretici = GetByCondition(x => x.SupplierName.ToLower().Equals(dto.SupplierName.ToLower().Trim()) && x.IsActive).FirstOrDefault();
                if (silinecekUretici != null)
                {
                    silinecekUretici.IsActive = false;
                    MySaveChanges();
                    nLogger.Info("{} üreticisi silindi", dto.SupplierName);
                    return true;
                }
                else
                {
                    throw new Exception(ExceptionMessages.SupplierNotFound);
                }
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

        public List<Supplier> GetSuppliersForAdmin()
        {
            try
            {
                List<Supplier> suppliers = GetByCondition(x => x.IsActive).ToList();
                if (suppliers == null)
                {
                    throw new Exception(ExceptionMessages.SupplierNotFoundForList);
                }
                else
                {
                    nLogger.Info("Supplier tablosu admin tarafından listelendi.");
                    return suppliers;
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public List<Supplier> GetSupplierListWithSearchbarForAdmin(string filter)
        {
            return GetByCondition(x => x.SupplierName.ToLower().Contains(filter.ToLower()) && x.IsActive);
        }
    }
}
