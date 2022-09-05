using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs.UserAdmin;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class UpdateUserMailValidator : AbstractValidator<UpdateUserEmailDTO>
    {
        public UpdateUserMailValidator()
        {
            RuleFor(x => x.UserID).GreaterThan(0).WithMessage(Messages.InvalidID);
            
            RuleFor(x => x.NewEmail).NotEmpty().WithMessage(Messages.InvalidID);
            RuleFor(x => x.NewEmail).MinimumLength(5).WithMessage(Messages.EmailMinLength);
            RuleFor(x => x.NewEmail).MaximumLength(50).WithMessage(Messages.EmailMaxLength);
            RuleFor(x => x.NewEmail).EmailAddress().WithMessage(Messages.InvalidEmail);
        }
    }
}
