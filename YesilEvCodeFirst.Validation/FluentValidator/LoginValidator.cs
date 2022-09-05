using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YesilEvCodeFirst.DTOs;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class LoginValidator : AbstractValidator<LoginDTO>
    {
        public LoginValidator()
        {
            #region Email Validation Login
            //Email validaton for Login 
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz.");
            RuleFor(x => x.Email).MinimumLength(5).WithMessage("Email alanı 5 karakterden küçük olamaz.");
            RuleFor(x => x.Email).MaximumLength(50).WithMessage("Email alanı 50 karakterden büyük olamaz.");
            RuleFor(x => x.Email).EmailAddress();
            #endregion

            #region Password Validation Login
            //Password validation for Login
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz.");
            RuleFor(x => x.Password).MaximumLength(30).WithMessage("Şifre alanı 30 karakterden büyük olamaz.");
            RuleFor(x => x.Password).MaximumLength(5).WithMessage("Şifre alanı 5 karakterden küçük olamaz.");
            #endregion
        }
    }
}
