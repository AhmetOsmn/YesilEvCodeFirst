using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.UserAdmin;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class SignUpValidator : AbstractValidator<AddUserDTO>
    {
        readonly Regex regEx = new Regex("^[a-zA-Z]*$");
        public SignUpValidator()
        {
            #region FirstName Validation Sign Up
            //FirstName Validation for Sign Up
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("İsim alanı boş bırakılamaz.");
            RuleFor(x => x.FirstName).MaximumLength(50).WithMessage("İsim alanı 50 karakterden büyük olamaz.");
            RuleFor(x => x.FirstName).MinimumLength(2).WithMessage("İsim alanı 2 karakterden küçük olamaz.");
            RuleFor(x => x.FirstName).Matches(regEx).WithMessage("İsim alanı özel karakterler içeremez.");
            #endregion

            #region LastName Validation Sign Up
            //LastName Validation Sign Up
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyisim alanı boş bırakılamaz.");
            RuleFor(x => x.LastName).MaximumLength(50).WithMessage("Soyisim alanı 50 karakterden büyük olamaz.");
            RuleFor(x => x.LastName).MinimumLength(2).WithMessage("Soyisim alanı 2 karakterden küçük olamaz.");
            RuleFor(x => x.LastName).Matches(regEx).WithMessage("Soyisim alanı özel karakterler içeremez.");
            #endregion


            #region Email Validation Sign Up
            //Email validaton for Login 
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz.");
            RuleFor(x => x.Email).MinimumLength(5).WithMessage("Email alanı 5 karakterden küçük olamaz.");
            RuleFor(x => x.Email).MaximumLength(50).WithMessage("Email alanı 50 karakterden büyük olamaz.");
            RuleFor(x => x.Email).EmailAddress();
            #endregion
        }
    }
}
