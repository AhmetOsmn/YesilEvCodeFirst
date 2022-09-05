using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.UserAdmin;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class UpdateUserDetailsValidator : AbstractValidator<UpdateUserDetailsDTO>
    {
        public UpdateUserDetailsValidator()
        {
            RuleFor(x => x.UserID).GreaterThan(0).WithMessage(Messages.InvalidID);

            RuleFor(x => x.FirstName).NotEmpty().WithMessage(Messages.FirstNameIsEmpty);
            RuleFor(x => x.FirstName).MaximumLength(100).WithMessage(Messages.FirstNameMaxLength);
            RuleFor(x => x.FirstName).MinimumLength(2).WithMessage(Messages.FirstNameMinLength);

            RuleFor(x => x.LastName).NotEmpty().WithMessage(Messages.LastNameIsEmpty);
            RuleFor(x => x.LastName).MaximumLength(100).WithMessage(Messages.LastNameMaxLength);
            RuleFor(x => x.LastName).MinimumLength(2).WithMessage(Messages.LastNameMinLength);

            RuleFor(x => x.Phone).NotEmpty().WithMessage(Messages.PhoneIsEmpty);
            RuleFor(x => x.Phone).MaximumLength(25).WithMessage(Messages.PhoneMaxLength);
            RuleFor(x => x.Phone).MinimumLength(10).WithMessage(Messages.PhoneMinLength);

        }
    }
}
