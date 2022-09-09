using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.UserAdmin;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class UpdateUserMailValidator : AbstractValidator<UpdateUserEmailDTO>
    {
        public UpdateUserMailValidator()
        {
            RuleFor(x => x.UserID).GreaterThan(0).WithMessage(ValidationMessages.InvalidID);

            RuleFor(x => x.NewEmail).NotEmpty().WithMessage(ValidationMessages.EmailIsEmpty);
            RuleFor(x => x.NewEmail).MinimumLength(5).WithMessage(ValidationMessages.EmailMinLength);
            RuleFor(x => x.NewEmail).MaximumLength(50).WithMessage(ValidationMessages.EmailMaxLength);
            RuleFor(x => x.NewEmail).EmailAddress().WithMessage(ValidationMessages.InvalidEmail);

            RuleFor(x => x.ReNewEmail).NotEmpty().WithMessage(ValidationMessages.EmailIsEmpty);
            RuleFor(x => x.ReNewEmail).Equal(X => X.NewEmail).WithMessage(ValidationMessages.EmailsNotEqual);

        }
    }
}
