using System;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Concrete;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.ExceptionHandling;
using YesilEvCodeFirst.Logs.Concrete;
using YesilEvCodeFirst.Validation.Login;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseAdminDAL : EfRepoBase<YesilEvDbContext, User>
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

                User user = dal.GetByCondition(users => users.Email.Equals(dto.Email) && users.Password.Equals(dto.Password) && users.RolID.Equals(3)).SingleOrDefault();

                if (user == null)
                {
                    throw new Exception("Admin bulunamadı.");
                }

                LogExtension.LogFunc(myLog, "", "Ahmet", "Giris islemi basarili", "User", Islem.Info);

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
