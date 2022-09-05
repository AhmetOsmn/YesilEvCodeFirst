using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class GetProductListWithUserIDValidator : AbstractValidator<IDDTO>
    {
        public GetProductListWithUserIDValidator()
        {
            RuleFor(x => x.ID).GreaterThan(0).WithMessage(Messages.InvalidID);
        }
    }
}
