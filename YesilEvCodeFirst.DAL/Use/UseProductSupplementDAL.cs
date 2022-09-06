using FluentValidation.Results;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.Supplement;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.FluentValidator;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseProductSupplementDAL : EfRepoBase<YesilEvDbContext, ProductSupplement>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        public List<ListSupplementDTO> GetSupplementsWithProductID(IDDTO dto)
        {
            IDDTOValidator validator = new IDDTOValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if(!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                List<ProductSupplement> productSupplements = GetByConditionWithInclude(u => u.ProductID.Equals(dto.ID) && u.IsActive,"Supplement").ToList();
                if (productSupplements != null)
                {
                    nLogger.Info("{} ID'li urune ait olan maddeler getirildi.", dto.ID);
                    return MappingProfile.ProductSupplementListToListSupplementDTOList(productSupplements);
                }
                else
                {
                    throw new Exception("Maddeler bulunamadı.");
                }
            }
            catch(FormatException fex)
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
    }
}
