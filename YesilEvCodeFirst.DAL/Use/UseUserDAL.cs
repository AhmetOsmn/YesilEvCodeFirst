using NLog;
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

        public UserDetailDTO UserLogin(LoginDTO dto)
        {
            LoginValidator validator = new LoginValidator(dto);

            try
            {
                if (!validator.IsValid)
                {
                    throw new ModelNotValidException(validator.ValidationMessages);
                }
                //using (YesilEvDbContext context = new YesilEvDbContext())
                //{
                //    var result = context.User.Where(u => u.Email.Equals(dto.Email) && u.Password.Equals(dto.Password)).FirstOrDefault();
                //    user = result;
                //}
                var user = GetByCondition(u => u.Email.Equals(dto.Email) && u.Password.Equals(dto.Password)).FirstOrDefault();
                if (user == null)
                {
                    throw new Exception("Kullanıcı bulunamadı.");
                }
                else{
                    nLogger.Info("{} - sisteme giris yapti.", user.FirstName + " " + user.LastName);
                    return MappingProfile.UserToGetUserDetailDTO(user);
                }
            }
            catch (ModelNotValidException ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }
            return null;
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
            }

            return null;
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
            }

            return null;
        }

        public bool UpdateUserDetails(UpdateUserDetailsDTO dto)
        {
            try
            {
                User tempUser = GetByCondition(x => x.UserID.Equals(dto)).FirstOrDefault();
                if (tempUser != null)
                {
                    tempUser.FirstName = dto.FirstName;
                    tempUser.LastName = dto.LastName;
                    tempUser.Phone = dto.Phone;
                    MySaveChanges();
                    nLogger.Info("{} - kullanicisinin bilgileri güncellendi.", tempUser.FirstName + " " + tempUser.LastName);
                    return true;
                }
                else
                {
                    throw new Exception("Kullanici Bulunamadi.");
                }

            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }
            
            return false;
        }
        public bool UpdateUserEmail(UpdateUserEmailDTO dto)
        {
            try
            {
                User tempUser = GetByCondition(x => x.UserID.Equals(dto)).FirstOrDefault();
                if (tempUser != null)
                {
                    tempUser.Email = dto.NewEmail;
                    MySaveChanges();
                    nLogger.Info("{} - kullanicisinin email bilgisi güncellendi.", tempUser.FirstName + " " + tempUser.LastName);
                    return true;
                }
                else
                {
                    throw new Exception("Kullanici Bulunamadi.");
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }

            return false;
        }
        public bool UpdateUserPassword(UpdateUserPasswordDTO dto)
        {
            try
            {
                User tempUser = GetByCondition(x => x.UserID.Equals(dto)).FirstOrDefault();
                if (tempUser != null)
                {
                    tempUser.Password = dto.NewPassword;
                    MySaveChanges();
                    nLogger.Info("{} - kullanicisinin sifre bilgisi güncellendi.", tempUser.FirstName + " " + tempUser.LastName);
                    return true;
                }
                else
                {
                    throw new Exception("Kullanici Bulunamadi.");
                }
            }
            catch (Exception ex)
            {
                nLogger.Error("System - {}", ex.Message);
            }

            return false;
        }
    }
}
