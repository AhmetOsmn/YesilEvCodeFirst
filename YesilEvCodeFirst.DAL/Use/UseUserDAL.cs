﻿using NLog;
using System;
using System.Linq;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.UserAdmin;
using YesilEvCodeFirst.ExceptionHandling;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.Login;
using YesilEvCodeFirst.Validation.User;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseUserDAL : EfRepoBase<YesilEvDbContext, User>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();

        public bool UserLogin(LoginDTO dto)
        {
            LoginValidator validator = new LoginValidator(dto);

            try
            {
                if (!validator.IsValid)
                {
                    throw new ModelNotValidException(validator.ValidationMessages);
                }

                User user = null;

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var result = context.User.Where(u => u.Email.Equals(dto.Email) && u.Password.Equals(dto.Password)).FirstOrDefault();
                    user = result;
                }

                if (user == null)
                {
                    throw new Exception("Kullanıcı bulunamadı.");
                }

                nLogger.Info("{} - sisteme giris yapti.", user.FirstName + " " + user.LastName);

                return true;
            }
            catch (ModelNotValidException ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }
            return false;
        }

        public bool AddUser(AddUserDTO dto)
        {
            AddUserValidator validator = new AddUserValidator(dto);

            try
            {
                if (!validator.IsValid)
                {
                    throw new ModelNotValidException(validator.ValidationMessages);
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
            catch (ModelNotValidException ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }
            return false;
        }
        public GetUserDetailDTO GetUserDetailWithEmail(string email)
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
            }

            return null;
        }
    }
}
