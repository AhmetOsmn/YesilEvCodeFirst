using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.UserAdmin;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class UpdateUserPasswordValidator : AbstractValidator<UpdateUserPasswordDTO>
    {
        public UpdateUserPasswordValidator()
        {
            RuleFor(x => x.UserID).GreaterThan(0).WithMessage(ValidationMessages.InvalidID);

            RuleFor(x => x.NewPassword).NotEmpty().WithMessage(ValidationMessages.PasswordIsEmpty);
            RuleFor(x => x.NewPassword).MinimumLength(5).WithMessage(ValidationMessages.PasswordMinLength);
            RuleFor(x => x.NewPassword).MaximumLength(30).WithMessage(ValidationMessages.PasswordMaxLength);

            RuleFor(x => x.ReNewPassword).NotEmpty().WithMessage(ValidationMessages.PasswordIsEmpty);
            RuleFor(x => x.ReNewPassword).Equal(x => x.NewPassword).WithMessage(ValidationMessages.PasswordsNotEqual);
        }
    }
}
