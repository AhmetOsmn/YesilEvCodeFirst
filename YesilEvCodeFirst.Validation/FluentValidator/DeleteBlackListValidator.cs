using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class DeleteBlackListValidator : AbstractValidator<IDDTO>
    {
        public DeleteBlackListValidator()
        {
            RuleFor(x => x.ID).GreaterThan(0).WithMessage(Messages.InvalidID);
        }
    }
}
