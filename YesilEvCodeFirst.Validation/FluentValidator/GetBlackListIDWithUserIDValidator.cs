using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class GetBlackListIDWithUserIDValidator : AbstractValidator<IDDTO>
    {
        public GetBlackListIDWithUserIDValidator()
        {
            RuleFor(x => x.ID).GreaterThan(0).WithMessage(Messages.InvalidID);  
        }
    }
}
