using NLog;
using System;
using System.Linq;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.ExceptionHandling;
using YesilEvCodeFirst.Validation.Login;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseAdminDAL : EfRepoBase<YesilEvDbContext, User>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();
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
                    nLogger.Info("{} - admin login islemi basarili.", tempUser.FirstName + " " + tempUser.LastName);
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
    }
}
