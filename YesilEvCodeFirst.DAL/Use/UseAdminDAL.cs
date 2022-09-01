using System;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.ExceptionHandling;
using YesilEvCodeFirst.Logs.Concrete;
using YesilEvCodeFirst.Validation.Login;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseAdminDAL : EfRepoBase<YesilEvDbContext, User> 
    {
        JsonLogger<LogDTO> myLog = new JsonLogger<LogDTO>("MyLog.txt");
        public bool AdminLogin(LoginDTO dto)
        {
            LoginValidator validator = new LoginValidator(dto);

            try
            {
                if (!validator.IsValid)
                {
                    throw new ModelNotValidException(validator.ValidationMessages);
                }

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    User tempUser = context.User.Where(u => u.Email.Equals(dto.Email) && u.Password.Equals(dto.Password) && u.RolID.Equals(1)).FirstOrDefault();
                    if (tempUser == null)
                    {
                        throw new Exception("Admin bulunamadı.");
                    }

                    LogExtension.LogFunc(myLog, "", "Ahmet", "Giris islemi basarili", "User", Islem.Info);
                }
                return true;
            }
            catch (ModelNotValidException ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "User", Islem.Error);
            }
            catch (Exception ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "User", Islem.Error);
            }
            return false;
        }
    }
}
