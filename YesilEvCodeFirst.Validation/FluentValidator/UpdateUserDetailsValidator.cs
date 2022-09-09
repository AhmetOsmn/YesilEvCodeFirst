using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.UserAdmin;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class UpdateUserDetailsValidator : AbstractValidator<UpdateUserDetailsDTO>
    {
        public UpdateUserDetailsValidator()
        {
            RuleFor(x => x.UserID).GreaterThan(0).WithMessage(ValidationMessages.InvalidID);

            RuleFor(x => x.FirstName).NotEmpty().WithMessage(ValidationMessages.FirstNameIsEmpty);
            RuleFor(x => x.FirstName).MaximumLength(100).WithMessage(ValidationMessages.FirstNameMaxLength);
            RuleFor(x => x.FirstName).MinimumLength(2).WithMessage(ValidationMessages.FirstNameMinLength);

            RuleFor(x => x.LastName).NotEmpty().WithMessage(ValidationMessages.LastNameIsEmpty);
            RuleFor(x => x.LastName).MaximumLength(100).WithMessage(ValidationMessages.LastNameMaxLength);
            RuleFor(x => x.LastName).MinimumLength(2).WithMessage(ValidationMessages.LastNameMinLength);

            RuleFor(x => x.Phone).NotEmpty().WithMessage(ValidationMessages.PhoneIsEmpty);
            RuleFor(x => x.Phone).MaximumLength(25).WithMessage(ValidationMessages.PhoneMaxLength);
            RuleFor(x => x.Phone).MinimumLength(10).WithMessage(ValidationMessages.PhoneMinLength);

        }
    }
}
