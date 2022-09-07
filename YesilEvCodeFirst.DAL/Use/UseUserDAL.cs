using FluentValidation.Results;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.UserAdmin;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.FluentValidator;
using YesilEvCodeFirst.Validation.FluentValidator.Const;

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

                var user = GetByCondition(u => u.Email.Equals(dto.Email) && u.Password.Equals(dto.Password) && u.IsActive).FirstOrDefault();
                if (user == null)
                {
                    throw new Exception(Messages.UserNotFound);
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
                    var tempUser = context.User.Where(u => u.Email.Equals(dto.Email) && u.IsActive).FirstOrDefault();
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
                        throw new Exception(Messages.EmailAlreadyExist);
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
        public UserDetailDTO GetUserDetailWithEmail(EmailDTO dto)
        {
            EmailDTOValidator validator = new EmailDTOValidator();
            ValidationResult validationResult = validator.Validate(dto);
            try
            {
                if(!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                User tempUser = GetByCondition(x => x.Email.Equals(dto.Email) && x.IsActive).FirstOrDefault();
                if (tempUser != null)
                {
                    nLogger.Info("{} - kullanicisinin bilgileri getirildi", tempUser.FirstName + " " + tempUser.LastName);
                    return MappingProfile.UserToGetUserDetailDTO(tempUser);
                }
                else
                {
                    throw new Exception(Messages.UserNotFound);
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
        public UserDetailDTO GetUserDetailWithID(IDDTO dto)
        {
            IDDTOValidator validator = new IDDTOValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if(!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                User tempUser = GetByCondition(x => x.UserID.Equals(dto.ID) && x.IsActive).FirstOrDefault();
                if (tempUser != null)
                {
                    nLogger.Info("{} - kullanicisinin bilgileri getirildi", tempUser.FirstName + " " + tempUser.LastName);
                    return MappingProfile.UserToGetUserDetailDTO(tempUser);
                }
                else
                {
                    throw new Exception(Messages.UserNotFound);
                }
            }
            catch(FormatException fex)
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
        public bool UpdateUserDetails(UpdateUserDetailsDTO dto)
        {
            UpdateUserDetailsValidator validator = new UpdateUserDetailsValidator();
            ValidationResult validationResult = validator.Validate(dto); 

            try
            {
                if(!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                User tempUser = GetByCondition(x => x.UserID.Equals(dto.UserID) && x.IsActive).FirstOrDefault();
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
                    throw new Exception(Messages.UserNotFound);
                }
            }
            catch(FormatException fex)
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
        public bool UpdateUserEmail(UpdateUserEmailDTO dto)
        {
            UpdateUserMailValidator validator = new UpdateUserMailValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if(!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                User tempUser = GetByCondition(x => x.UserID.Equals(dto.UserID) && x.IsActive).FirstOrDefault();
                if (tempUser != null)
                {
                    tempUser.Email = dto.NewEmail;
                    MySaveChanges();
                    nLogger.Info("{} - kullanicisinin email bilgisi güncellendi.", tempUser.FirstName + " " + tempUser.LastName);
                    return true;
                }
                else
                {
                    throw new Exception(Messages.UserNotFound);
                }
            }
            catch(FormatException fex)
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
        public bool UpdateUserPassword(UpdateUserPasswordDTO dto)
        {
            UpdateUserPasswordValidator validator = new UpdateUserPasswordValidator();
            ValidationResult validationResult = validator.Validate(dto);

            try
            {
                if(!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                User tempUser = GetByCondition(x => x.UserID.Equals(dto.UserID) && x.IsActive).FirstOrDefault();
                if (tempUser != null)
                {
                    tempUser.Password = dto.NewPassword;
                    MySaveChanges();
                    nLogger.Info("{} - kullanicisinin sifre bilgisi güncellendi.", tempUser.FirstName + " " + tempUser.LastName);
                    return true;
                }
                else
                {
                    throw new Exception(Messages.UserNotFound);
                }
            }
            catch(FormatException fex)
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
        public List<User> GetAllUserDetailForAdmin()
        {
            return GetAll();
        }
        public List<User> GetUserWithFilterForAdmin(string filter)
        {
            return GetByCondition(x=>x.FirstName.Contains(filter)&& x.IsActive).ToList();
        }
        public User GetUserWithEmailForAdmin(string email)
        {
            return GetByCondition(x=>x.Email.Equals(email)&& x.IsActive).FirstOrDefault();
        }
        public bool DeleteUserWithEmailForAdmin(string email)
        {
            try
            {
                Delete(GetUserWithEmailForAdmin(email));
                MySaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Silme Başarısız");
            }
        }
        public bool UpdateUserForAdmin(UserForAdminDTO dto)
        {
            try
            {
                var temp = GetByCondition(x => x.UserID == dto.UserID && x.IsActive).FirstOrDefault();
                temp.FirstName = dto.FirstName;
                temp.LastName = dto.LastName;
                temp.Email = dto.Email;
                temp.Phone = dto.Phone;
                temp.Password = dto.Password;
                temp.RolID = dto.RolID;
                MySaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hata Oluştu");
            }
        }
        public bool AddUserForAdmin(UserForAdminDTO dto)
        {
            try
            {
                User user = MappingProfile.UserForAdminDTOtoUser(dto);
                Add(user);
                MySaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Hata Oluştu.");
            }
            
        }
    }
}
