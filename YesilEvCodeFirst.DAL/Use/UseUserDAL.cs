using System;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Concrete;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.UserAdmin;
using YesilEvCodeFirst.ExceptionHandling;
using YesilEvCodeFirst.Logs.Concrete;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.Login;
using YesilEvCodeFirst.Validation.User;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseUserDAL : EfRepoBase<YesilEvDbContext, User>
    {
        JsonLogger<LogDTO> myLog = new JsonLogger<LogDTO>("MyLog.txt");

        public bool Login(LoginDTO dto)
        {
            LoginValidator validator = new LoginValidator(dto);

            try
            {
                if (!validator.IsValid)
                {
                    throw new ModelNotValidException(validator.ValidationMessages);
                }

                UserDAL dal = new UserDAL();

                User user = dal.GetByCondition(users => users.Email.Equals(dto.Email) && users.Password.Equals(dto.Password)).SingleOrDefault();

                if (user == null)
                {
                    throw new Exception("Kullanıcı bulunamadı.");
                }

                LogExtension.LogFunc(myLog, "", "Ahmet", "Giris islemi basarili", "Login", Islem.Info);

                return true;
            }
            catch (ModelNotValidException ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Login", Islem.Error);
            }
            catch (Exception ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Login", Islem.Error);
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

                UserDAL dal = new UserDAL();
                User adduser = MappingProfile.AddUserDTOtoUser(dto);
                dal.Add(adduser);
                dal.MySaveChanges();

                LogExtension.LogFunc(myLog, "", "Ahmet", "Ekleme islemi basarili", "User", Islem.Info);

                return true;
            }
            catch (ModelNotValidException ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "User", Islem.Error);
            }
            catch (Exception ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Urun", Islem.Error);
            }
            return false;
        }
    }
}
