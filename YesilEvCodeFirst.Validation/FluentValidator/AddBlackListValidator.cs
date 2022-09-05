using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class AddBlackListValidator : AbstractValidator<IDDTO>
    {
        public AddBlackListValidator()
        {
            RuleFor(bl => bl.ID).GreaterThan(0).WithMessage(Messages.InvalidID);
        }
    }
}
