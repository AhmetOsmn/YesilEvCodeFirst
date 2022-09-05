using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.UserAdmin;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class UpdateUserPasswordValidator : AbstractValidator<UpdateUserPasswordDTO>
    {
        public UpdateUserPasswordValidator()
        {
            RuleFor(x => x.UserID).GreaterThan(0).WithMessage(Messages.InvalidID);

            RuleFor(x => x.NewPassword).NotEmpty().WithMessage(Messages.PasswordIsEmpty);
            RuleFor(x => x.NewPassword).MinimumLength(5).WithMessage(Messages.PasswordMinLength);
            RuleFor(x => x.NewPassword).MaximumLength(30).WithMessage(Messages.PasswordMaxLength);
        }
    }
}
