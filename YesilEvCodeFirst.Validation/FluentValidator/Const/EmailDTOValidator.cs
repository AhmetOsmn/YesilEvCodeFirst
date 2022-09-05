using FluentValidation;
using YesilEvCodeFirst.DTOs;

namespace YesilEvCodeFirst.Validation.FluentValidator.Const
{
    public class EmailDTOValidator : AbstractValidator<EmailDTO>
    {
        public EmailDTOValidator()
        {
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz.");
            RuleFor(x => x.Email).MinimumLength(5).WithMessage("Email alanı 5 karakterden küçük olamaz.");
            RuleFor(x => x.Email).MaximumLength(50).WithMessage("Email alanı 50 karakterden büyük olamaz.");
            RuleFor(x => x.Email).EmailAddress();
        }
    }
}
