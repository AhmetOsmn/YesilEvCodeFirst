﻿using FluentValidation.Results;
using NLog;
using System;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.UserAdmin;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.FluentValidator;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseUserDAL : EfRepoBase<YesilEvDbContext, User>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        public UserDetailDTO UserLogin(LoginDTO dto)
        {

            LoginValidator validator = new LoginValidator();
            ValidationResult validationResult = validator.Validate(dto);
            
            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }
                var user = GetByCondition(u => u.Email.Equals(dto.Email) && u.Password.Equals(dto.Password)).FirstOrDefault();
                if (user == null)
                {
                    throw new Exception("Kullanıcı bulunamadı.");
                }
                else
                {
                    nLogger.Info("{} - sisteme giris yapti.", user.FirstName + " " + user.LastName);
                    return MappingProfile.UserToGetUserDetailDTO(user);
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

        public bool AddUser(AddUserDTO dto)
        {
            SignUpValidator validator = new SignUpValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var tempUser = context.User.Where(u => u.Email.Equals(dto.Email)).FirstOrDefault();
                    if (tempUser == null)
                    {
                        User addUser = MappingProfile.AddUserDTOtoUser(dto);
                        addUser.RolID = 2;
                        // todo: password hashlenerek ve sold'lama yapilarak db'ye kaydedilmeli
                        context.User.Add(addUser);
                        context.SaveChanges();
                        nLogger.Info("{} - sisteme kayit oldu.", addUser.FirstName + " " + addUser.LastName);
                    }
                    else
                    {
                        throw new Exception("Email ile kayitli kullanici mevcut.");
                    }
                }

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
        public UserDetailDTO GetUserDetailWithEmail(string email)
        {
            try
            {
                User tempUser = GetByCondition(x => x.Email.Equals(email)).FirstOrDefault();
                if (tempUser != null)
                {
                    nLogger.Info("{} - kullanicisinin bilgileri getirildi", tempUser.FirstName + " " + tempUser.LastName);
                    return MappingProfile.UserToGetUserDetailDTO(tempUser);
                }
                else
                {
                    throw new Exception("Kullanici bulunamadi.");
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public UserDetailDTO GetUserDetailWithID(int id)
        {
            try
            {
                User tempUser = GetByCondition(x => x.UserID.Equals(id)).FirstOrDefault();
                if (tempUser != null)
                {
                    nLogger.Info("{} - kullanicisinin bilgileri getirildi", tempUser.FirstName + " " + tempUser.LastName);
                    return MappingProfile.UserToGetUserDetailDTO(tempUser);
                }
                else
                {
                    throw new Exception("Kullanici bulunamadi.");
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
