using FluentValidation;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.DTOs;

namespace YesilEvCodeFirst.Validation.FluentValidator
{
    public class GetProductDetailWithProductIDValidator : AbstractValidator<IDDTO>
    {
        public GetProductDetailWithProductIDValidator()
        {
            RuleFor(x => x.ID).GreaterThan(0).WithMessage(Messages.InvalidID);
        }
    }
}
