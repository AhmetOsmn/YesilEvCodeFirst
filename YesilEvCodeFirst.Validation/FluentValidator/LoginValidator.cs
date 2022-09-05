using FluentValidation;
using YesilEvCodeFirst.DTOs;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class LoginValidator : AbstractValidator<LoginDTO>
    {
        public LoginValidator()
        {
            #region Email Validation Login Page
            //Email validaton for Login Page
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz.");
            RuleFor(x => x.Email).MinimumLength(5).WithMessage("Email alanı 5 karakterden küçük olamaz.");
            RuleFor(x => x.Email).MaximumLength(50).WithMessage("Email alanı 50 karakterden büyük olamaz.");
            RuleFor(x => x.Email).EmailAddress();
            #endregion

            #region Password Validation Login Page
            //Password validation for Login Page
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz.");
            RuleFor(x => x.Password).MaximumLength(30).WithMessage("Şifre alanı 30 karakterden büyük olamaz.");
            RuleFor(x => x.Password).MinimumLength(5).WithMessage("Şifre alanı 5 karakterden küçük olamaz.");
            #endregion
        }
    }
}
