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
using YesilEvCodeFirst.DTOs.SearchHistory;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.FluentValidator;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseSearchHistoryDAL : EfRepoBase<YesilEvDbContext, SearchHistory>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        public bool AddSearchHistory(AddSearchHistoryDTO dto)
        {
            SearchHistoryValidator validator = new SearchHistoryValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                Add(MappingProfile.AddSearchHistoryDTOToSearchHistory(dto));
                MySaveChanges();

                nLogger.Info("{} Kullanicisi {} urununu aradi.", dto.UserID, dto.ProductID);
                return true;
            }
            catch (FormatException fex)
            {
                nLogger.Error("System - {}", fex.Message);
                throw new FormatException(fex.Message);
            }
        }

        public List<SearchHistoryDTO> GetSearchHistoryList()
        {
            try
            {
                List<SearchHistory> searchHistoryList = GetAll();

                if (searchHistoryList == null)
                {
                    throw new Exception(Messages.SearchHistoryNotFoundForList);
                }
                else
                {
                    List<SearchHistoryDTO> searchHistoryDTOList = MappingProfile.SearchHistoryListToSearchHistoryDTOList(searchHistoryList);

                    nLogger.Info("SearchHistory tablosu listelendi.");

                    return searchHistoryDTOList;
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }

        }

        public List<SearchHistoryDTO> GetSearchHistoryListWithUserID(IDDTO dto)
        {
            IDDTOValidator validator = new IDDTOValidator();  
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if(!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                List<SearchHistory> searchHistoryList = GetByConditionWithInclude(x => x.UserID == dto.ID, "User", "Product");

                if (searchHistoryList == null)
                {
                    throw new Exception(Messages.SearchHistoryNotFoundForList);
                }
                else
                {
                    List<SearchHistoryDTO> searchHistoryDTOList = MappingProfile.SearchHistoryListToSearchHistoryDTOListWithInclude(searchHistoryList);

                    nLogger.Info("SearchHistory tablosu listelendi.");

                    return searchHistoryDTOList;
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

        public bool ClearSearchHistoryWithUserID(IDDTO dto)
        {
            IDDTOValidator validator = new IDDTOValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if(!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                var histories = GetByCondition(x => x.UserID == dto.ID).ToList();
                DeleteRange(histories);
                MySaveChanges();
                return true;
            }
            catch (FormatException fex)
            {
                nLogger.Error("System - {}", fex.Message);
                throw new FormatException(fex.Message);
            }
        }
    }
}
