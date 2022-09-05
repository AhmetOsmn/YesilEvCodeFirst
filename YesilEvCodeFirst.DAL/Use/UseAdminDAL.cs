using FluentValidation.Results;
using NLog;
using System;
using System.Linq;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.Validation.FluentValidator;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseAdminDAL : EfRepoBase<YesilEvDbContext, User>
    {
        readonly Logger nLogger = LogManager.GetCurrentClassLogger();
        public bool AdminLogin(LoginDTO dto)
        {
            LoginValidator validator = new LoginValidator();
            ValidationResult validationResult = validator.Validate(dto);
            try
            {
                if (!validationResult.IsValid)
                {
                    throw new FormatException(validationResult.Errors[0].ErrorMessage);
                }

                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    User tempUser = context.User.Where(u => u.Email.Equals(dto.Email) && u.Password.Equals(dto.Password) && u.RolID.Equals(1)).FirstOrDefault();
                    if (tempUser == null)
                    {
                        throw new Exception(Messages.AdminNotFound);
                    }
                    nLogger.Info("{} - admin login islemi basarili.", tempUser.FirstName + " " + tempUser.LastName);
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
    }
}
