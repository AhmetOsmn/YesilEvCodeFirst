using FluentValidation;
using YesilEvCodeFirst.DTOs.UserAdmin;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class SignUpValidator : AbstractValidator<AddUserDTO>
    {
        //to do: Validation Regex türkçe kullanımına bak.
        //readonly Regex regEx = new Regex("^[a-zA-Z0-9ğüşöçİĞÜŞÖÇ]*$");
        public SignUpValidator()
        {
            #region FirstName Validation Sign Up Page
            //FirstName Validation for Sign Up Page
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("İsim alanı boş bırakılamaz.");
            RuleFor(x => x.FirstName).MaximumLength(50).WithMessage("İsim alanı 50 karakterden büyük olamaz.");
            RuleFor(x => x.FirstName).MinimumLength(2).WithMessage("İsim alanı 2 karakterden küçük olamaz.");
            //RuleFor(x => x.FirstName).Matches(regEx).WithMessage("İsim alanı özel karakterler içeremez.");
            #endregion

            #region LastName Validation Sign Up Page
            //LastName Validation Sign Up Page
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyisim alanı boş bırakılamaz.");
            RuleFor(x => x.LastName).MaximumLength(50).WithMessage("Soyisim alanı 50 karakterden büyük olamaz.");
            RuleFor(x => x.LastName).MinimumLength(2).WithMessage("Soyisim alanı 2 karakterden küçük olamaz.");
            //RuleFor(x => x.LastName).Matches(regEx).WithMessage("Soyisim alanı özel karakterler içeremez.");
            #endregion

            #region Email Validation Sign Up Page
            //Email validaton for Sign Up Page
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz.");
            RuleFor(x => x.Email).MinimumLength(5).WithMessage("Email alanı 5 karakterden küçük olamaz.");
            RuleFor(x => x.Email).MaximumLength(50).WithMessage("Email alanı 50 karakterden büyük olamaz.");
            RuleFor(x => x.Email).EmailAddress();
            #endregion
            
            #region Password Validation Sign Up Page
            //Password validation for Sig Up Page
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz.");
            RuleFor(x => x.Password).MaximumLength(30).WithMessage("Şifre alanı 30 karakterden büyük olamaz.");
            RuleFor(x => x.Password).MinimumLength(5).WithMessage("Şifre alanı 5 karakterden küçük olamaz.");
            #endregion

            //#region Phone Validation Sign Up
            ////Phone validation for Sign Up
            //RuleFor(x => x.Phone).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz.");
            //RuleFor(x => x.Phone).MaximumLength(11).WithMessage("Şifre alanı 11 karakterden büyük olamaz.");
            //RuleFor(x => x.Phone).MinimumLength(11).WithMessage("Şifre alanı 11 karakterden küçük olamaz.");
            //#endregion
        }
    }
}
