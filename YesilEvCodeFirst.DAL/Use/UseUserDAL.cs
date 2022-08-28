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

                LogExtension.LogFunc(myLog, "", "Ahmet", "Ekleme islemi basarili", "Login", Islem.Info);

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
    }
}
